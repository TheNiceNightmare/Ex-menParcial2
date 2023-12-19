namespace ExámenParcial2.Services.Interfaces;

public interface ILoginService
{
    public Task<bool> LoginAsync(string usuario, string contraseña);
}