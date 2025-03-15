namespace Vereinsportal.Interfaces
{
    public interface IUser
    {
        string UserName();
        string? UserAddress();
        string? UserGender();
        string? UserPhone();
        string UserEmail();

    }
}
