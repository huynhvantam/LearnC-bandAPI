using BandAPI3.Entities;
using System;
using System.Collections.Generic;

namespace BandAPI3.Services
{
   public interface IBandAlbumRepository
   {
      IEnumerable<Album> GetAlbums(Guid bandId);
      Album GetAlbum(Guid bandId, Guid albumId);
      void AddAlbum(Guid bandId, Album album);
      void UpdateAlbum(Album album);
      void DeleteAlbum(Album album);

      IEnumerable<Band> GetBands();
      Band GetBand(Guid bandId);
      IEnumerable<Band> GetBands(IEnumerable<Guid> bandIds);
      void AddBand(Band band);
      void Updateband(Band band);
      void DeleteBand(Band band);

      bool BandExists(Guid bandId);
      bool AlbumExists(Guid bandId);
      bool Save();
   }
}
