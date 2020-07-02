namespace TailSpin.SpaceGame.Web.Models
{
    public class ErrorViewModel
    {
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string RequestId { get; set; }

        
    }
}