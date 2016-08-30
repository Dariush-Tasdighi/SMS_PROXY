namespace SmsProxy
{
	/// <summary>
	/// Version: 1.0.0
	/// Update Date: 1395/06/09
	/// Changed In Version: 1.0.0
	/// Developer: Mr. Dariush Tasdighi
	/// </summary>
	public class BaseRequest : System.Object
	{
		public BaseRequest()
			: base()
		{
		}

		// **********
		/// <summary>
		/// شناسه کاربری
		/// </summary>
		public string Username { get; set; }
		// **********

		// **********
		/// <summary>
		/// گذرواژه
		/// </summary>
		public string Password { get; set; }
		// **********
	}
}
