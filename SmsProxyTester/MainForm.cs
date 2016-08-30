using System.Linq;

namespace MyApplication
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void btnDisplayCredit_Click(object sender, System.EventArgs e)
		{
			SmsProxy.BaseRequest oRequest = new SmsProxy.BaseRequest();

			oRequest.Username = txtUsername.Text;
			oRequest.Password = txtPassword.Text;

			SmsProxy.ResponseForGetCredit
				oResponse = SmsProxy.Utility.GetCredit(oRequest);

			if (oResponse.State == SmsProxy.Enums.ResponseStates.LastStepDone)
			{
				System.Windows.Forms.MessageBox.Show("Credit: " + oResponse.Credit);
			}
			else
			{
				string strMessage =
					"State: " + oResponse.State +
					System.Environment.NewLine +
					"Error Message: " + oResponse.ErrorMessage
					;

				System.Windows.Forms.MessageBox.Show(strMessage);
			}
		}

		private void btnGetPanelExpireDate_Click(object sender, System.EventArgs e)
		{
			SmsProxy.BaseRequest oRequest = new SmsProxy.BaseRequest();

			oRequest.Username = txtUsername.Text;
			oRequest.Password = txtPassword.Text;

			SmsProxy.ResponseForGetPanelExpireDate
				oResponse = SmsProxy.Utility.GetPanelExpireDate(oRequest);

			if (oResponse.State == SmsProxy.Enums.ResponseStates.LastStepDone)
			{
				System.Windows.Forms.MessageBox.Show("Expire Date: " + oResponse.ExpireDate);
			}
			else
			{
				string strMessage =
					"State: " + oResponse.State +
					System.Environment.NewLine +
					"Error Message: " + oResponse.ErrorMessage
					;

				System.Windows.Forms.MessageBox.Show(strMessage);
			}
		}
	}
}
