using System;
using PBInfrastructure;
using Xunit;

namespace Infrastructure.Tests;

public class ProjectRepositoryTests : IDisposable
{
    private readonly PBContext _context;
    private readonly ProjectRepository _repository;

    [Fact]
    public void Delete_()
    {

    }

    [Fact]
    public void ListAll_()
    {

    }

    [Fact]
    public void Update_()
    {

    }

    [Fact]
    public void ReadByID_()
    {

    }

    

    private bool disposed;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }

            disposed = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

}