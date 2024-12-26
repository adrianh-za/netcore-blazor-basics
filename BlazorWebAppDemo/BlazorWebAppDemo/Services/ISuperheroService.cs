using BlazorWebAppDemo.Model;

namespace BlazorWebAppDemo.Services;

public interface ISuperheroService
{
    List<Superhero> GetData();
    int GetDataCount();
    Task<List<Superhero>> GetDataAsync(int startIndex,int numberofrecords, CancellationToken cancelationToken);
}