namespace SmsProxy
{
	/// <summary>
	/// Version: 1.0.0
	/// Update Date: 1395/06/09
	/// Changed In Version: 1.0.0
	/// Developer: Mr. Dariush Tasdighi
	/// </summary>
	public class BaseResponse : System.Object
	{
		internal BaseResponse()
			: base()
		{
		}

		// **********
		public string ErrorMessage { get; internal set; }
		// **********

		// **********
		public System.Exception Exception { get; internal set; }
		// **********

		// **********
		public Enums.ResponseStates State { get; internal set; }
		// **********
	}
}
