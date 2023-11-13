using DTOs.MbBank;
using FetchDataApiMbBank.Comons;
using FetchDataApiMbBank.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FetchDataApiMbBank.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MbBanksController : ControllerBase
	{
		private readonly MbBankService mbBankService;

		public MbBanksController(MbBankService mbBankService)
		{
			this.mbBankService = mbBankService;
		}

		#region History Transaction
		[HttpGet("HistoryTransaction")]
		public async Task<object?> GetHistoryTransaction(string fromDate, string toDate)
		{
			try
			{

				(DateTime? from, DateTime? to) = Util.PaserDateTimeFromDateToDate(fromDate, toDate);	
				if(from == null || to == null) 
				{
					return StatusCode(StatusCodes.Status400BadRequest, "Invalid date");
				}
				var data = await mbBankService.GetHistoryTransaction(from, to);
				return data;
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}
		#endregion

		#region History Transaction
		[HttpPost("HistoryTransaction")]
		public async Task<object?> GetHistoryTransaction(MbBankRequestBodyHistoryTransactionDTO request)
		{
			try
			{
				(DateTime? from, DateTime? to) = Util.PaserDateTimeFromDateToDate(request.fromDate, request.toDate);
				if (from == null || to == null)
				{
					return StatusCode(StatusCodes.Status400BadRequest, "Invalid date");
				}
				var data = await mbBankService.GetHistoryTransaction(request);
				return data;
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}
		#endregion
	}
}
