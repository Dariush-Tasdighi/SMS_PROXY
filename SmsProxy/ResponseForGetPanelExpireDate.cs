namespace SmsProxy
{
	/// <summary>
	/// Version: 1.0.0
	/// Update Date: 1395/06/09
	/// Changed In Version: 1.0.0
	/// Developer: Mr. Dariush Tasdighi
	/// </summary>
	public class ResponseForGetPanelExpireDate : BaseResponse
	{
		internal ResponseForGetPanelExpireDate()
			: base()
		{
		}

		// **********
		public string ExpireDate { get; internal set; }
		// **********
	}
}
