# Azure AD Integrated Service Template


### Introduction
The Azure AD Integrated Service template comes with support for Azure AD Authentication Libraries. The integrated ADAL enables user to easily authenticate user to cloud or on premise Azure Active Directory and obtain access tokens for securing API calls. The Azure AD Authentication Library helps to focus on business logic and easily secure resources without going through the hassle of configuring ADAL. This template can be directly used for development by changing “Tenant” and “Audience” key in web config file with the respective keys from Azure portal. “Response URL” set in Azure portal should be equal to Build URL configured in the project.

### Basic useful feature list:
* Configurable token cache
* Automatic token refresh
* Secure resources 

### Prerequisites 
For using this template, you first need an app service. You can refer to this [link](https://docs.microsoft.com/en-us/azure/app-service-mobile/app-service-mobile-how-to-configure-active-directory-authentication) for creating an app service.

### How to install the template
Clone this repository from the top right corner or use the command
```
$ git clone
```

### Initial configuration
* Change  the Tenant key and Audience key present in the web.config file with your Azure Tenant and Audience keys
``` 
<appSettings>
	<add key = "ida:Tenant" value = "<alpha-numeic key>" \>
    <add key = "ida:Audience" value = "<alpha-numeric key"> \>
</appSettings>
```
* Change your Project/Response URL present in the Project -> Properties -> Web, with your Azure Response URL 
* Build the project
* Set Pages -> LandingPage.html as Startup Page and run the solution. 


### How to use the template:

On running the solution, Landing page will start the project. After the user clicks on Login, page will redirect to Microsoft login page which requires the user to enter the credentials. The authentication process is already handled by the template and Azure app service.

When the users are authenticated, they will be redirected to a sample page which has three buttons on the top.
* Post
* Get
* Ping

On clicking the button, coressponding Http request is fired. 

User can customize their Http requests as per the needs and use this template as the starting point to add more functionalties to their application.
