using System.ComponentModel.DataAnnotations;

namespace NotificationAPI.Model
{
    //public class UserDetails
    //{
        
    //    public string EmailId { get; set; }
       

    //}

    //public class response
    //{
    //    public string GenarateOTP { get; set; }
    //    // public bool otptest { get; set; }
    //    public string StatusCode { get; set; }
    //    public string Status { get; set; }
    //    public string Message { get; set; }
    //}
   
    
    public class Mailresponse
    {
        //public string Email{ get; set; }
        // public bool otptest { get; set; }
        public string StatusCode { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }

}

