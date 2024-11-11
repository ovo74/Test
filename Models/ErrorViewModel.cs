namespace MeidaManagementSystem.Models
{
    public class MediaManagementSystemContext
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
