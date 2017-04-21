///<disable>JS2032, JS2074, JS3058, JS3057, JS3055</disable>

var oADALObject = (function () {
    "use strict";

    //// Get UI jQuery Objects
    var $panel = $(".panel-body");
    var $userDisplay = $(".app-user");
    var $signInButton = $(".app-login");
    var $signOutButton = $(".app-logout");
    var $errorMessage = $(".app-error");
    var tokenID = "";
    var sPingEndPoint = "/ping/ping";
    var sLocalEndPoint = "/Data";
    /// <disable>JS3092</disable>
    /// <disable>DeclarePropertiesBeforeUse</disable>
    /// <disable>JS3092.DeclarePropertiesBeforeUse</disable>
    //// Location.prototype is being used to get the current web location. User needs to alter this location to respective website.
    var sServiceURL = window.location.origin + "/LandingPage.html";

    /// Enter Global Configuration Values. 
    /// Modify instance,tenant,clientId as per azure application details
    var oConfiguration = {
        instance: "https://login.microsoftonline.com/",
        tenant: "e4d98dd2-9199-42e5-ba8b-da3e763ede2e",
        clientId: "922765bc-5151-488f-852c-d3ebc6874ae7",
        postLogoutRedirectUri: sServiceURL,
        cacheLocation: "localStorage", // Enable this for IE, as sessionStorage does not work for 'Local host'
    };
    // Instantiate ADAL AuthenticationContext
    var authContext = new AuthenticationContext(oConfiguration);
    var isCallback = authContext.isCallback(window.location.hash);

    // Check For & Handle Redirect From AAD After Login
    authContext.handleWindowCallback();
    if (isCallback && !authContext.getLoginError()) {
        window.location = authContext._getItem(authContext.CONSTANTS.STORAGE.LOGIN_REQUEST);
    }

    // Check Login Status, Update UI
    var user = authContext.getCachedUser();
    if (user) {
        $userDisplay.html(user.userName);
        $userDisplay.show();
        $signInButton.hide();
        $signOutButton.show();
    } else {
        $userDisplay.empty();
        $userDisplay.hide();
        $signInButton.show();
        $signOutButton.hide();
    }

    // Check if View Requires Authentication
    if (!authContext.getCachedUser()) {
        authContext.config.redirectUri = window.location.href;
        authContext.login();
        return;
    }
    var loadModal = function (bShow, sMessage, sTitle) {
        "use strict";
        $("#modalTitle").text(sTitle ? sTitle : "An error occurred please try again later.");
        $("#errorText").text(sMessage ? sMessage : "Information");
        bShow ? $("#modalBox").modal("show") : $("#modalBox").modal("hide");
    };

    // Get token for back-end

    authContext.acquireToken(authContext.config.clientId, function (error, token) {
        "use strict";
        // Handle ADAL Errors
        if (error || !token) {
            authContext.logOut();
            window.location = sServiceURL;
        }
        tokenID = token.valueOf();
    });


    // Function to perform operations on page load 
    $(document).ready(function () {


        // Register Navigation Bar Click Handlers
        $signOutButton.click(function () {
            "use strict";
            authContext.logOut();
        });
        $signInButton.click(function () {
            "use strict";
            authContext.login();
        });
        // Ping button click handler
        $("#ping").click(function (e) {
            "use strict";
            // Parameters: /Controller/Attribute,Get or Post,Value on Success, Value on Failure.
            oADALUserDataObject.callUserProvisionService(sPingEndPoint, "Get", onSuccess, onFailure);
        });
        $("#get").click(function (e) {
            "use strict";
            // Parameters: /Controller,Get or Post,Value on Success, Value on Failure.
            oADALUserDataObject.callUserProvisionService(sLocalEndPoint, "Get", onSuccess, onFailure);
        });
        $("#post").click(function (e) {
            "use strict";
            // Parameters: /Controller,Get or Post,Value on Success, Value on Failure.
            oADALUserDataObject.callUserProvisionService(sLocalEndPoint, "Post", onSuccess, onFailure);
        });
        // Handle and process successful output
        var onSuccess = function (result) {
            "use strict";
            loadModal(true, result, "Success");

        };
        // Handle and process failure output
        var onFailure = function (result) {
            "use strict";
            loadModal(true, result, "Failure");
        };

    });

    return {
        getToken: function () {
            return tokenID;
        }
    };
}());
