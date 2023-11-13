using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using DTOs.MbBank;
using DTOs.Bank;
using FetchDataApiMbBank.Comons;
using DigitalFUHubApi.Comons;

namespace FetchDataApiMbBank.Services
{
	public class MbBankService
	{
		private HttpClient client;
		private readonly IConfiguration configuration;

		public MbBankService(IConfiguration configuration)
		{
			this.configuration = configuration;

			client = new HttpClient();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			client.DefaultRequestHeaders.Add("Authorization", "Basic " + configuration["MbBank:BasicAuthBase64"]);
		}


		public async Task<MbBankResponeHistoryTransactionDataDTO?> GetHistoryTransaction()
		{
			MbBankRequestBodyHistoryTransactionDTO mbBank = new MbBankRequestBodyHistoryTransactionDTO()
			{
				accountNo = configuration["MbBank:AccountNo"],
				deviceIdCommon = configuration["MbBank:DeviceIdCommon"],
				refNo = configuration["MbBank:RefNo"],
				fromDate = DateTime.Now.AddDays(-5).ToString("dd/MM/yyyy"),
				sessionId = configuration["MbBank:SessionId"],
				toDate = DateTime.Now.ToString("dd/MM/yyyy")
			};

			var jsonData = JsonSerializer.Serialize(mbBank);
			var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var request = await client.PostAsync(configuration["MbBank:ApiHistoryTransaction"], content);

			var respone = await request.Content.ReadAsStringAsync();

			var options = new JsonSerializerOptions();
			options.Converters.Add(new JsonSerializerDateTimeConverter());
			options.Converters.Add(new JsonSerializerIntConverter());

			var data = JsonSerializer.Deserialize<MbBankResponeHistoryTransactionDataDTO>(respone, options);

			return data;
		}

		public async Task<MbBankResponeHistoryTransactionDataDTO?> GetHistoryTransaction(MbBankRequestBodyHistoryTransactionDTO mbBank)
		{
			var jsonData = JsonSerializer.Serialize(mbBank);
			var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var request = await client.PostAsync(configuration["MbBank:ApiHistoryTransaction"], content);

			var respone = await request.Content.ReadAsStringAsync();

			var options = new JsonSerializerOptions();
			options.Converters.Add(new JsonSerializerDateTimeConverter());
			options.Converters.Add(new JsonSerializerIntConverter());

			var data = JsonSerializer.Deserialize<MbBankResponeHistoryTransactionDataDTO>(respone, options);

			return data;
		}

		public async Task<MbBankResponse?> InquiryAccountName(BankInquiryAccountNameRequestDTO bankInquiryAccountNameRequestDTO)
		{
			MbBankRequestBodyInquiryAccountNameDTO mbBank = new MbBankRequestBodyInquiryAccountNameDTO()
			{
				bankCode = bankInquiryAccountNameRequestDTO.BankId,
				creditAccount = bankInquiryAccountNameRequestDTO.CreditAccount,
				creditAccountType = "ACCOUNT",
				debitAccount = configuration["MbBank:AccountNo"],
				deviceIdCommon = configuration["MbBank:DeviceIdCommon"],
				refNo = configuration["MbBank:RefNo"],
				remark = string.Empty,
				sessionId = configuration["MbBank:SessionId"],
				type = bankInquiryAccountNameRequestDTO.BankId == Constants.BANK_ID_MB_BANK? "INHOUSE" : "FAST"
			};

			var jsonData = JsonSerializer.Serialize(mbBank);
			var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var request = await client.PostAsync(configuration["MbBank:ApiInquiryAccountName"], content);

			var respone = await request.Content.ReadAsStringAsync();

			var options = new JsonSerializerOptions();
			options.Converters.Add(new JsonSerializerDateTimeConverter());
			options.Converters.Add(new JsonSerializerIntConverter());

			var data = JsonSerializer.Deserialize<MbBankResponeInquiryAccountNameDTO>(respone, options);

			if (data == null) return null;

			MbBankResponse mbBankResponse = new MbBankResponse()
			{
				Code = data.result.responseCode,
				Result = data.benName
			};

			return mbBankResponse;
		}
	}
}
