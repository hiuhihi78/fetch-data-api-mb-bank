namespace FetchDataApiMbBank.Comons
{
	public static class Constants
	{
		//MB bank config
		public const string BANK_ID_MB_BANK = "970422";
		public const int NUMBER_DAYS_CAN_UPDATE_BANK_ACCOUNT = 15;
		public const string BANK_TRANSACTION_CODE_KEY = "FU";

		public const string MB_BANK_RESPONE_CODE_SUCCESS = "00";
		public const string MB_BANK_RESPONE_CODE_SESSION_INVALID = "GW200";
		public const string MB_BANK_RESPONE_CODE_SAME_URI_IN_SAME_TIME = "GW485";
		public const string MB_BANK_RESPONE_CODE_ACCOUNT_NOT_FOUND = "MC201";
		public const string MB_BANK_RESPONE_CODE_SEARCH_WITH_TYPE_ERR = "MC231";
	}
}
