using BandAPI.DbContexts;
using BandAPI3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BandAPI3.Services
{
   public class BandAlbumRepository : IBandAlbumRepository
   {
      private readonly BandAlbumContext _context;
      public BandAlbumRepository(BandAlbumContext context)
      {
         _context = context ?? throw new ArgumentNullException(nameof(context));
      }


      public void AddAlbum(Guid bandId, Album album)
      {
         if (bandId == Guid.Empty)
            throw new ArgumentNullException(nameof(bandId));

         if (album == null)
            throw new ArgumentNullException(nameof(album));

         album.BandId = bandId;
         _context.Albums.Add(album);
      }

      public void AddBand(Band band)
      {
         if (band == null)
            throw new ArgumentNullException(nameof(band));

         _context.Bands.Add(band);
      }

      public bool AlbumExists(Guid albumId)
      {
         if (albumId == Guid.Empty)
            throw new ArgumentNullException(nameof(albumId));
         return _context.Albums.Any(a => a.Id == albumId);
      }

      public bool BandExists(Guid bandId)
      {
         if (bandId == Guid.Empty)
            throw new ArgumentNullException(nameof(bandId));
         return _context.Bands.Any(b => b.Id == bandId);

      }

      public void DeleteAlbum(Album album)
      {
         if (album == null)
            throw new ArgumentNullException(nameof(album));
         _context.Albums.Remove(album);
      }

      public void DeleteBand(Band band)
      {
         if (band == null)
            throw new ArgumentNullException(nameof(band));
         _context.Bands.Remove(band);
      }

      public Album GetAlbum(Guid bandId, Guid albumId)
      {
         if (bandId == Guid.Empty)
            throw new ArgumentNullException(nameof(bandId));

         if (albumId == Guid.Empty)
            throw new ArgumentNullException(nameof(albumId));

         return _context.Albums
            .Where(a => a.BandId == bandId && a.Id == albumId)
            .FirstOrDefault();
      }

      public IEnumerable<Album> GetAlbums(Guid bandId)
      {
         if (bandId == Guid.Empty)
            throw new ArgumentNullException(nameof(bandId));

         return _context.Albums
            .Where(a => a.BandId == bandId)
            .OrderBy(a => a.Title)
            .ToList();
      }

      public Band GetBand(Guid bandId)
      {
         if (bandId == Guid.Empty)
            throw new ArgumentNullException(nameof(bandId));

         return _context.Bands
            .FirstOrDefault(b => b.Id == bandId);
      }

      public IEnumerable<Band> GetBands()
      {
         return _context.Bands
            .ToList();
      }

      public IEnumerable<Band> GetBands(IEnumerable<Guid> bandIds)
      {
         if (bandIds == null)
            throw new ArgumentNullException(nameof(bandIds));

         return _context.Bands
            .Where(b => bandIds.Contains(b.Id))
            .OrderBy(b => b.Name)
            .ToList();
      }

      public bool Save()
      {
         return (_context.SaveChanges() >= 0);
      }

      public void UpdateAlbum(Album album)
      {
         //not implemented
      }

      public void Updateband(Band band)
      {
         //not    implemented
      }
   }
}
