namespace RCCWebApi.DTO.MobileLogin
{
    public class ReadOnlyMobileLoginDto
    {
        public int MobileLoginId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool? PasswordReset { get; set; }
    }
}
