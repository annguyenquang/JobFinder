using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service;

public class MetadataProfile: Profile
{
    public MetadataProfile()
    {
        CreateMap<Metadata, MetadataModel>();
    }
}
