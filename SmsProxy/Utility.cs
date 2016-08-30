namespace SmsProxy
{
	/// <summary>
	/// Version: 1.0.0
	/// Update Date: 1395/06/09
	/// Changed In Version: 1.0.0
	/// Developer: Mr. Dariush Tasdighi
	/// </summary>
	public static class Utility
	{
		const string VERSION = "1.0.0";

		static Utility()
		{
		}

		internal static string GetErrorMessage(int state)
		{
			switch (state)
			{
				case 110:
				{
					return ("موجودی شارژ نزد تاپ‌آپ کافی نمی‌باشد!");
				}

				case 120:
				{
					return ("نام کاربری یا رمز عبور تاپ‌آپ اشتباه است!");
				}

				case 130:
				{
					return ("حساب کاربری نزد تاپ‌آپ مسدود می‌باشد!");
				}

				case 140:
				{
					return ("کد پذیرنده نزد تاپ‌آپ اشتباه می‌باشد!");
				}

				case 150:
				{
					return ("خطای داخلی نزد تاپ‌آپ رخ داده است!");
				}

				case 160:
				{
					return ("در اپراتور مشکل داخلی پیش آمده است!");
				}

				case 170:
				{
					return ("شماره تلفن همراه اشتباه می‌باشد!");
				}

				default:
				{
					return ("خطای ناشناخته");
				}
			}
		}

		/// <summary>
		/// دریافت اعتبار
		/// </summary>
		public static ResponseForGetCredit GetCredit(BaseRequest request)
		{
			ResponseForGetCredit oResponse = new ResponseForGetCredit();

			oResponse.State =
				Enums.ResponseStates.BeforeStart;

			string strUrl =
				string.Format("http://niksms.com/fa/publicapi/getCredit?username={0}&password={1}",
				request.Username, request.Password);

			oResponse.State =
				Enums.ResponseStates.Step01Done;

			System.Net.WebRequest oWebRequest =
				System.Net.WebRequest.Create(strUrl);

			oResponse.State =
				Enums.ResponseStates.Step02Done;

			oWebRequest.Method = "GET";
			oWebRequest.Timeout = 100000; // Default: [100000]
			oWebRequest.PreAuthenticate = false; // Default: [false]
			oWebRequest.UseDefaultCredentials = false; // Default: [false]

			//oWebRequest.Proxy
			//oWebRequest.Headers
			//oWebRequest.RequestUri
			//oWebRequest.CachePolicy
			//oWebRequest.ContentType
			//oWebRequest.Credentials
			//oWebRequest.ContentLength
			//oWebRequest.ConnectionGroupName
			//oWebRequest.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
			//oWebRequest.ImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.None;

			System.IO.Stream oResponseStream = null;
			System.Net.WebResponse oWebResponse = null;
			System.IO.StreamReader oStreamReader = null;

			try
			{
				oWebResponse =
					oWebRequest.GetResponse();

				oResponse.State =
					Enums.ResponseStates.Step03Done;

				System.Net.HttpStatusCode enmStatusCode =
					((System.Net.HttpWebResponse)oWebResponse).StatusCode;

				if (enmStatusCode == System.Net.HttpStatusCode.OK)
				{
					oResponse.State =
						Enums.ResponseStates.Step05Done;

					// **************************************************
					//oResponseStream =
					//	oWebResponse.GetResponseStream();

					//oStreamReader =
					//	new System.IO.StreamReader(oResponseStream);

					//string strResponseFromServer = oStreamReader.ReadToEnd();
					// **************************************************

					// **************************************************
					//System.Runtime.Serialization.Json.DataContractJsonSerializer oJsonSerializer =
					//	new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(InternalResponse));

					//InternalResponse oTopUpChargeResponse =
					//	(InternalResponse)oJsonSerializer.ReadObject(oWebResponse.GetResponseStream());
					// **************************************************

					oResponseStream =
						oWebResponse.GetResponseStream();

					oResponse.State =
						Enums.ResponseStates.Step06Done;

					oStreamReader =
						new System.IO.StreamReader(oResponseStream);

					oResponse.State =
						Enums.ResponseStates.Step07Done;

					string strResponseFromServer = oStreamReader.ReadToEnd();

					oResponse.State =
						Enums.ResponseStates.Step08Done;

					oResponse.Credit =
						System.Convert.ToInt32(strResponseFromServer);

					oResponse.State =
						Enums.ResponseStates.LastStepDone;
				}
				else
				{
					oResponse.State =
						Enums.ResponseStates.Step04Done;

					//string strStatusDescription =
					//	((System.Net.HttpWebResponse)oWebResponse).StatusDescription;

					oResponse.ErrorMessage =
						GetErrorMessage((int)enmStatusCode);
				}
			}
			catch (System.Exception ex)
			{
				oResponse.Exception = ex;
				oResponse.ErrorMessage = "خطای ناشناخته";
			}
			finally
			{
				if (oStreamReader != null)
				{
					oStreamReader.Close();
					oStreamReader.Dispose();
					oStreamReader = null;
				}

				if (oResponseStream != null)
				{
					oResponseStream.Close();
					oResponseStream.Dispose();
					oResponseStream = null;
				}

				if (oWebResponse != null)
				{
					oWebResponse.Close();
					oWebResponse.Dispose();
					oWebResponse = null;
				}
			}

			return (oResponse);
		}

		/// <summary>
		/// تاریخ انقضای پنل کاربری
		/// </summary>
		public static ResponseForGetPanelExpireDate GetPanelExpireDate(BaseRequest request)
		{
			ResponseForGetPanelExpireDate oResponse = new ResponseForGetPanelExpireDate();

			oResponse.State =
				Enums.ResponseStates.BeforeStart;

			string strUrl =
				string.Format("http://niksms.com/fa/publicapi/getpanelexpiredate?username={0}&password={1}",
				request.Username, request.Password);

			oResponse.State =
				Enums.ResponseStates.Step01Done;

			System.Net.WebRequest oWebRequest =
				System.Net.WebRequest.Create(strUrl);

			oResponse.State =
				Enums.ResponseStates.Step02Done;

			oWebRequest.Method = "GET";
			oWebRequest.Timeout = 100000; // Default: [100000]
			oWebRequest.PreAuthenticate = false; // Default: [false]
			oWebRequest.UseDefaultCredentials = false; // Default: [false]

			//oWebRequest.Proxy
			//oWebRequest.Headers
			//oWebRequest.RequestUri
			//oWebRequest.CachePolicy
			//oWebRequest.ContentType
			//oWebRequest.Credentials
			//oWebRequest.ContentLength
			//oWebRequest.ConnectionGroupName
			//oWebRequest.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
			//oWebRequest.ImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.None;

			System.IO.Stream oResponseStream = null;
			System.Net.WebResponse oWebResponse = null;
			System.IO.StreamReader oStreamReader = null;

			try
			{
				oWebResponse =
					oWebRequest.GetResponse();

				oResponse.State =
					Enums.ResponseStates.Step03Done;

				System.Net.HttpStatusCode enmStatusCode =
					((System.Net.HttpWebResponse)oWebResponse).StatusCode;

				if (enmStatusCode == System.Net.HttpStatusCode.OK)
				{
					oResponse.State =
						Enums.ResponseStates.Step05Done;

					// **************************************************
					//oResponseStream =
					//	oWebResponse.GetResponseStream();

					//oStreamReader =
					//	new System.IO.StreamReader(oResponseStream);

					//string strResponseFromServer = oStreamReader.ReadToEnd();
					// **************************************************

					// **************************************************
					//System.Runtime.Serialization.Json.DataContractJsonSerializer oJsonSerializer =
					//	new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(InternalResponse));

					//InternalResponse oTopUpChargeResponse =
					//	(InternalResponse)oJsonSerializer.ReadObject(oWebResponse.GetResponseStream());
					// **************************************************

					oResponseStream =
						oWebResponse.GetResponseStream();

					oResponse.State =
						Enums.ResponseStates.Step06Done;

					oStreamReader =
						new System.IO.StreamReader(oResponseStream);

					oResponse.State =
						Enums.ResponseStates.Step07Done;

					string strResponseFromServer = oStreamReader.ReadToEnd();

					oResponse.State =
						Enums.ResponseStates.Step08Done;

					oResponse.ExpireDate = strResponseFromServer;

					oResponse.State =
						Enums.ResponseStates.LastStepDone;
				}
				else
				{
					oResponse.State =
						Enums.ResponseStates.Step04Done;

					//string strStatusDescription =
					//	((System.Net.HttpWebResponse)oWebResponse).StatusDescription;

					oResponse.ErrorMessage =
						GetErrorMessage((int)enmStatusCode);
				}
			}
			catch (System.Exception ex)
			{
				oResponse.Exception = ex;
				oResponse.ErrorMessage = "خطای ناشناخته";
			}
			finally
			{
				if (oStreamReader != null)
				{
					oStreamReader.Close();
					oStreamReader.Dispose();
					oStreamReader = null;
				}

				if (oResponseStream != null)
				{
					oResponseStream.Close();
					oResponseStream.Dispose();
					oResponseStream = null;
				}

				if (oWebResponse != null)
				{
					oWebResponse.Close();
					oWebResponse.Dispose();
					oWebResponse = null;
				}
			}

			return (oResponse);
		}
	}
}
