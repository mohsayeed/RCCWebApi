namespace RCCWebApi.DTO.DailyRate
{
    public class ReadOnlyDailyRates
    {
        public DateTime DailyDate { get; set; }
        public decimal? LiveRate { get; set; }
        public decimal? SkinlessRate { get; set; }
        public decimal? WithSkinRate { get; set; }
        public TimeSpan CutOffTime { get; set; }
    }
}
