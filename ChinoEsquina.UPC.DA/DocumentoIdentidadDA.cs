﻿using ChinoEsquina.UPC.EF;

namespace ChinoEsquina.UPC.DA
{
    public class DocumentoIdentidadDA
    {
        private readonly dbChinoEsquinaContext dc;

        public DocumentoIdentidadDA()
        {
            dc = new dbChinoEsquinaContext();
        }

        public List<DocumentoIdentidad> FindAll() { 
            return dc.DocumentoIdentidads.ToList();
        }
    }
}