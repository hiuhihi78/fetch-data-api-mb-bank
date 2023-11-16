using FetchDataApiMbBank.Services;
using Quartz;

namespace FetchDataApiMbBank.Jobs
{
	public class HistoryTransactionMbBankJob : IJob
	{
		private readonly IConfiguration configuration;
		private readonly MbBankService mbBankService;

		public HistoryTransactionMbBankJob(IConfiguration configuration, MbBankService mbBankService)
		{
			this.configuration = configuration;
			this.mbBankService = mbBankService;
		}

		public async Task Execute(IJobExecutionContext context)
		{
			//return;
			// This job scheduler help to saving sessionId of Mb bank
			await mbBankService.GetHistoryTransaction();
			return;
		}
	}
}
