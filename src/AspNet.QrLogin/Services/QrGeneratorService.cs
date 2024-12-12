using AspNet.QrLogin.Abstractions;
using AspNet.QrLogin.Components;

namespace AspNet.QrLogin.Services;

public class QrGeneratorService : IQrGeneratorService
{
    public Task<QrCode> GenerateQrCode()
    {
        throw new NotImplementedException();
    }
}