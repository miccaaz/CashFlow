using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Infrasctructure.DataAccess;
using CashFlow.Infrasctructure.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Infrasctructure;

public static class DependencyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services, configuration);
        AddRepositories(services);
    }

    // Adicionando os Repositorios de Salvar e Adicionar
    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IUnityOfWork, UnityOfWork>();
        services.AddScoped<IExpensesRepository, ExpensesRepository>();
    }

    // Adicionando caminho para o Banco de Dados
    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        var conectionString = configuration.GetConnectionString("Connection");
        services.AddDbContext<CashFlowDbContext>(config => config.UseNpgsql(conectionString));
    }
}
