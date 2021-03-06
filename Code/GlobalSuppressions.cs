#region "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "As per standards"
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "namespace", Target = "MAQ.LDP.WebService.App_Start", Justification = "As per MAQ Standards")]
#endregion
#region "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "As per standards"
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LDP", Scope = "namespace", Target = "MAQ.LDP.WebService", Justification = "As per MAQ Standards")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MAQ", Scope = "namespace", Target = "MAQ.LDP.WebService", Justification = "As per MAQ Standards")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Justification = "As per MAQ Standards")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LDP", Justification = "As per MAQ Standards")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MAQ", Justification = "As per MAQ Standards")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ADAL")]
#endregion
#region "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "As per standards"
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Api", Scope = "type", Target = "MAQ.LDP.WebService.WebApiApplication", Justification = "As per MAQ Standards")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Api", Scope = "type", Target = "MAQ.LDP.WebService.App_Start.WebApiConfig", Justification = "As per MAQ Standards")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Api", Scope = "type", Target = "MAQ.LDP.WebService.WebApiConfig", Justification = "As per MAQ Standards")]
#endregion
#region "CA1822:MarkMembersAsStatic", Justification = "Need to implement interface System.Web.HttpApplication" 
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "MAQ.LDP.WebService.WebApiApplication.#Application_Start()", Justification = "Need to implement interface System.Web.HttpApplication")]
#endregion
#region "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Its a logger exception. Cannot do anything since logger fails to log the error message on Azure database."
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MAQ.LDP.WebService.Logger.#LoggerTypeException(System.String,System.String,System.Diagnostics.EventLogEntryType,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MAQ.LDP.WebService.AzureLogger.#LoggerTypeException(System.String,System.String,System.Diagnostics.EventLogEntryType)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MAQ.LDP.WebService.AzureLogger.#LoggerTypeException(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "MAQ.LDP.WebService.EventLogger.#LogEventTypeException(System.String,System.Diagnostics.EventLogEntryType)")]

#endregion


// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

