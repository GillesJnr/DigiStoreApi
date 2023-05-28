namespace DigiStoreApi.Models;

public static class StaticVariables
{
    public enum RequestStatus
    {
        Declined,
        Success,
        Pending,
        Approved
    }

    public static int Successcode { get; set; } = 1;
    public static int Failedcode { get; set; } = 0;
    public static int Pendingcode { get; set; } = 2;
    public static string Success { get; set; } = "SUCCESS";
    public static string Failed { get; set; } = "FAILED";
    public static string Pending { get; set; } = "PENDING";
    public static string Recordfailure { get; set; } = "FAILED TO SAVE";
    public static string Succcessstatusmessage { get; set; } = "REQUEST SUCCESSFUL";
    public static string Sentforapproval { get; set; } = "RECORD SENT FOR APPROVAL";
    public const string Loginattemptfailed = "Incorrect Username or password";
    public static string Servererrormassage = "Unable to connect to remote host";
    public static string Exceptionerror = "ERROR";
    public static string Servererrormessage = "Connection was lost";
    public static string Failedmessage = "Invalid request";
    public static string ExceptionError = "An Error Occured";
    public static string Notfound = "Record Not Found";
    public static string NoData = "No Data Found";
    public const string? Bearer = "Bearer";


    public const string? CreatedBy = "InitialUser";
    public const string? AuthorizedBy = "ApproveUser";
    public const string? ModifiedBy = "ModifyUser";

}