///<disable>JS2032, JS2074, JS3058</disable>
// Function contains generic methods 
var oADALUserDataObject = (function () {
    "use strict";
    var oCommonConstants = {
        // Generic function for Ajax call to service controller
        callUserService: function (sWebMethodName, sServiceType, onSuccess, onFailure, sData) {
            "use strict";
            
            var sWebMethodUrl = "api" + sWebMethodName;
            $.ajax({
                headers: { authorization: "bearer " + oADALObject.getToken() },
                type: sServiceType,
                url: sWebMethodUrl,
                data: sData,
                processData: false,
                contentType: false,
                dataType: "JSON",
                // Handle successful result
                success: function (result) {
                    "use strict";
                    onSuccess(result);
                },
                // Handle failure result
                error: function (result) {
                    "use strict";
                    onFailure(oADALObject.getToken() === "" ? "Session has Expired" : result);
                }
            });
        },
    };
    // Return generic Ajax call to service controller function 
    return {
        callUserProvisionService: function (sWebMethodName, sServiceType, onSuccess, onFailure, sData) {
            "use strict";
            oCommonConstants.callUserService(sWebMethodName, sServiceType, onSuccess, onFailure, sData);
        }
    };
}());