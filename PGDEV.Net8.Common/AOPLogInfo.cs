namespace PGDEV.Net8.Common
{
    public class AOPLogInfo
    {
        /// <summary>
        /// RequestTime
        /// </summary>
        public string RequestTime { get; set; } = string.Empty;
        /// <summary>
        /// OpUserName
        /// </summary>
        public string OpUserName { get; set; } = string.Empty;
        /// <summary>
        /// RequestMethodName
        /// </summary>
        public string RequestMethodName { get; set; } = string.Empty;
        /// <summary>
        /// RequestParamsName
        /// </summary>
        public string RequestParamsName { get; set; } = string.Empty;
        /// <summary>
        /// RequestParamsData
        /// </summary>
        public string RequestParamsData { get; set; } = string.Empty;
        /// <summary>
        /// ResponseIntervalTime
        /// </summary>
        public string ResponseIntervalTime { get; set; } = string.Empty;
        /// <summary>
        /// ResponseTime
        /// </summary>
        public string ResponseTime { get; set; } = string.Empty;
        /// <summary>
        /// ResponseJsonData
        /// </summary>
        public string ResponseJsonData { get; set; } = string.Empty;
    }
}
