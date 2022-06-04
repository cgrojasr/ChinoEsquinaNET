using AutoMapper;
using ChinoEsquina.UPC.API.Models;
using ChinoEsquina.UPC.EF;

namespace ChinoEsquina.UPC.API.Profiles
{
    public class DocumentoIdentidadProfile: Profile
    {
        public DocumentoIdentidadProfile()
        {
            CreateMap<DocumentoIdentidad, DocumentoIdentidadModel>().ReverseMap();
        }
    }
}
