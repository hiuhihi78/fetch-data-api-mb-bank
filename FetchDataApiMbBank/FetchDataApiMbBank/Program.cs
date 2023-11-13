using FetchDataApiMbBank.Jobs;
using Quartz;
using System.Text.Json.Serialization;

namespace FetchDataApiMbBank
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			// Remove cycle object's data in json respone
			builder.Services.AddControllers().AddJsonOptions(options =>
			{
				options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
			});

			// add job scheduler get history transaction bank
			builder.Services.AddQuartz(q =>
			{
				var jobKeyHistoryTranasctionMbBank = new JobKey("HistoryDepositTransactionMbBankJob");
				q.AddJob<HistoryTransactionMbBankJob>(opts => opts.WithIdentity(jobKeyHistoryTranasctionMbBank));
				q.AddTrigger(opts => opts
					.ForJob(jobKeyHistoryTranasctionMbBank)
					.StartNow()
					.WithSimpleSchedule(x =>
						x.WithIntervalInMinutes(1)
						.RepeatForever()
						)
					);
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.UseCors();

			app.MapControllers();

			app.Run();
		}
	}
}