using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;
using System.Data.Entity;
using System.Linq.Expressions;
using System.ComponentModel;
using DVDMC;

namespace MyDVDsDAL.DALServices
{
    public class DALServices
    {
        #region variables & constants

        const int CDCASEICON = 3;
        const int DVDCASEICON = 4;
        const int DVDDISCICON = 6;

        #endregion

        #region Box

        // ADD a new Box - no related records
        public static StorageBox AddABox(MyDVDsContext context, string boxtype)
        {
            StorageBox sb = new StorageBox();

            // get next box #
            sb.BoxNumber = GetNextBoxNumber(context);

            // init fields
            sb.BoxType = boxtype;
            sb.Notes = "";

            // add it
            context.StorageBoxes.Add(sb);
            context.SaveChanges();

            return sb;
        }

        // get next available box # for adding a new box
        public static int GetNextBoxNumber(MyDVDsContext context)
        {
            int nxtnumber = 1;
            if (context.StorageBoxes.Count() > 0)
            {
                nxtnumber = context.StorageBoxes.Max(n => n.BoxNumber);
                nxtnumber += 1;
            }

            return nxtnumber;
        }

        // get a box by number
        public static StorageBox GetBox(MyDVDsContext context, int boxnumber)
        {
            StorageBox box = context.StorageBoxes
                              .Where(p => p.BoxNumber == boxnumber)
                              .FirstOrDefault();

            return box;
        }

        #endregion

        #region Case

        // ADD the next Case to a specific box
        public static Case AddNextCase(MyDVDsContext context, int boxnum)
        {
            StorageBox sb = new StorageBox();
            Case ca = new Case();

            // get the box
            sb = GetBox(context, boxnum);

            // set next case number
            ca.CaseNumber = GetNextCaseNumber(sb);

            // set fields
            ca.CaseType = sb.BoxType;
            ca.Notes = "";
            ca.IsABoxset = false;
            ca.Title = "";


            // set parent nav
            ca.StorageBoxId = sb.Id;
            sb.TotalCases++;
            ca.StorageBox = sb;

            // set lookup navs
            switch (ca.CaseType)
            {
                case "CD":
                    ca.DVDIconId = CDCASEICON;
                    break;
                case "DVD":
                    ca.DVDIconId = DVDCASEICON;
                    break;
                default:
                    ca.DVDIconId = CDCASEICON;
                    break;
            }

            ca.DVDIcon = GetDVDIcon(context, ca.DVDIconId);

            // add the new case to the box
            sb.Cases.Add(ca);
            context.SaveChanges();

            return ca;
        }

        // get next available case # for adding a new case to the box object
        public static int GetNextCaseNumber(StorageBox box)
        {
            int nxtnumber = 1;
            if (box.Cases.Count() > 0)
            {
                nxtnumber = box.Cases.Max(n => n.CaseNumber);
                nxtnumber += 1;
            }

            return nxtnumber;
        }

        // get a case by number
        public static Case GetCase(MyDVDsContext context, int boxnumber, int casenumber)
        {
            Case ca = context.Cases
                       .Where(s => s.StorageBox.BoxNumber == boxnumber && s.CaseNumber == casenumber)
                       .FirstOrDefault();

            return ca;
        }

        #endregion

        #region Disc

        // ADD the next Disc to a specific case/box
        public static Disc AddNextDisc(MyDVDsContext context, int boxnum, int casenum)
        {
            Case ca = new Case();
            Disc di = new Disc();

            // get the box specific case
            ca = GetCase(context, boxnum, casenum);

            // set the next disc #
            di.DiscNumber = GetNextDiscNumber(ca);

            // set fields
            di.Notes = "";
            di.IsACollection = false;
            di.Title = "";

            // set parent nav
            di.CaseId = ca.Id;
            ca.TotalDiscs++;
            di.Case = ca;

            // add the new disc to the case
            ca.Discs.Add(di);
            context.SaveChanges();

            return di;
        }

        // get next available disc # for adding a new disc to the case object
        public static int GetNextDiscNumber(Case ca)
        {
            int nxtnumber = 1;

            if (ca.Discs.Count() > 0)
            {
                nxtnumber =
                nxtnumber = ca.Discs.Max(n => n.DiscNumber);
                nxtnumber += 1;
            }

            return nxtnumber;
        }

        // get a disc by number
        public static Disc GetDisc(MyDVDsContext context, int boxnumber, int casenumber, int discnumber)
        {
            Disc di = context.Discs
                       .Where(s => s.Case.StorageBox.BoxNumber == boxnumber && s.Case.CaseNumber == casenumber && s.DiscNumber == discnumber)
                       .FirstOrDefault();

            return di;
        }

        #endregion

        #region Content

        // ADD the next Content to a specific disc/case/box
        public static Content AddNextContent(MyDVDsContext context, int boxnum, int casenum, int discnum)
        {
            Disc di = new Disc();
            Content co = new Content();

            // get the disc
            di = GetDisc(context, boxnum, casenum, discnum);

            // get next content #
            co.ContentNumber = GetNextContentNumber(di);

            // set fields
            co.Notes = "";
            co.Title = "";
            co.Year = "";
            co.Cast = "";
            co.Director = "";

            // set parent nav
            co.DiscId = di.Id;
            di.TotalContents++;
            co.Disc = di;

            // set lookup navs
            co.GenreId = 1;
            co.Genre = GetGenre(context, co.GenreId);

            co.RatingId = 1;
            co.Rating = GetRating(context, co.RatingId);

            co.DVDIconId = DVDDISCICON;
            co.DVDIcon = GetDVDIcon(context, co.DVDIconId);

            // add the new content to the disc
            di.Contents.Add(co);
            context.SaveChanges();

            return co;
        }

        // get next available content # for adding a new content to the disc object
        public static int GetNextContentNumber(Disc di)
        {
            int nxtnumber = 1;
            if (di.Contents.Count() > 0)
            {
                nxtnumber = di.Contents.Max(n => n.ContentNumber);
                nxtnumber += 1;
            }

            return nxtnumber;
        }

        // get a content by number
        public static Content GetContent(MyDVDsContext context, int boxnumber, int casenumber, int discnumber, int contentnumber)
        {
            Content co = context.Contents
                       .Where(c => c.Disc.Case.StorageBox.BoxNumber == boxnumber && c.Disc.Case.CaseNumber == casenumber && c.Disc.DiscNumber == discnumber && c.ContentNumber == contentnumber)
                       .FirstOrDefault();

            return co;
        }

        // get all contents
        public static List<AllContentForGrid> GetAllContents(MyDVDsContext context)
        {
             List<AllContentForGrid> allCntL = new List<AllContentForGrid>();

             allCntL = context.Contents
                        .Select(x => new AllContentForGrid {
                            Title = x.Title,
                            Year = x.Year,
                            Box = x.Disc.Case.StorageBox.BoxNumber,
                            Case = x.Disc.Case.CaseNumber,
                            Disc = x.Disc.Case.CaseNumber,
                            Sel = x.ContentNumber,
                            Id = x.Id })
                        .ToList();

            return allCntL;
        }

        // get a content by id
        public static Content GetContentById(MyDVDsContext context, int id)
        {
            Content co = context.Contents
                       .Where(c => c.Id == id)
                       .FirstOrDefault();

            return co;
        }

        public static List<Content> SearchForTitle(MyDVDsContext context, string title)
        {
            List<Content> coList = context.Contents
                       .Where(c => c.Title.Contains(title))
                        .ToList();


            return coList;

        }

        #endregion

        #region Lookups

        public static Genre GetGenre(MyDVDsContext context, int genreid)
        {
            var g = context.Genres
                     .Where(i => i.Id == genreid).FirstOrDefault();

            return g;
        }

        public static List<Genre> GetAllGenres(MyDVDsContext context)
        {
            var g = context.Genres.ToList();

            return g;
        }

        public static Genre UpdateGenre(MyDVDsContext context, Genre newgenre)
        {
            var oldgenre = GetGenre(context, newgenre.Id);

            context.Entry(oldgenre).CurrentValues.SetValues(newgenre);
            context.SaveChanges();

            newgenre = GetGenre(context, newgenre.Id);

            return newgenre;
        }

        public static Genre AddGenre(MyDVDsContext context, Genre newgnr)
        {
            // add it
            context.Genres.Add(newgnr);

            context.SaveChanges();

            newgnr = GetGenre(context, newgnr.Id);

            return newgnr;
        }

        public static Genre GetGenreByname(MyDVDsContext context, string name)
        {
            var Genre = context.Genres
                    .Where(i => i.Name == name).FirstOrDefault();

            return Genre;
        }

        public static List<AllGenresForGrid> GetAllGenresForGrid(MyDVDsContext context)
        {
            List<AllGenresForGrid> allGnrL = new List<AllGenresForGrid>();

            allGnrL = context.Genres
                       .Select(x => new AllGenresForGrid { Id = x.Id, GenreName = x.Name })
                       .OrderBy(x => x.GenreName)
                       .ToList();

            return allGnrL;
        }

        public static int DeleteGenre(MyDVDsContext context, Genre gnr)
        {
            context.Entry(gnr).State = EntityState.Deleted;
            return context.SaveChanges();
        }


        public static bool IsGenreDuplicate(MyDVDsContext context, string name)
        {
            return context.Genres.Any(x => x.Name == name);
        }

        public static Rating GetRating(MyDVDsContext context, int ratingid)
        {
            var r = context.Ratings
                     .Where(i => i.Id == ratingid).FirstOrDefault();

            return r;
        }

        public static Rating AddRating(MyDVDsContext context, Rating newRtg)
        {
            // add it
            context.Ratings.Add(newRtg);

            context.SaveChanges();

            newRtg = GetRating(context, newRtg.Id);

            return newRtg;
        }

        public static Rating GetRatingByCode(MyDVDsContext context, string mpaacode)
        {
            var Rating = context.Ratings
                    .Where(i => i.MPAACode == mpaacode).FirstOrDefault();

            return Rating;
        }

        public static List<AllRatingsForGrid> GetAllRatingsForGrid(MyDVDsContext context)
        {
            List<AllRatingsForGrid> allRtgL = new List<AllRatingsForGrid>();

            allRtgL = context.Ratings
                       .Select(x => new AllRatingsForGrid { Id = x.Id, MPAACode = x.MPAACode, Description = x.Description })
                       .OrderBy(x => x.MPAACode)
                       .ToList();

            return allRtgL;
        }

        public static List<Rating> GetAllRatings(MyDVDsContext context)
        {
            var r = context.Ratings.ToList();

            return r;
        }

        public static int DeleteRating(MyDVDsContext context, Rating Rtg)
        {
            context.Entry(Rtg).State = EntityState.Deleted;
            return context.SaveChanges();
        }


        public static bool IsRatingDuplicate(MyDVDsContext context, string mpaacode)
        {
            return context.Ratings.Any(x => x.MPAACode == mpaacode);
        }


        public static Rating UpdateRating(MyDVDsContext context, Rating newrating)
        {
            var oldrating = GetRating(context, newrating.Id);

            context.Entry(oldrating).CurrentValues.SetValues(newrating);
            context.SaveChanges();

            newrating = GetRating(context, newrating.Id); 

            return newrating;
        }

        public static DVDIcon GetDVDIcon(MyDVDsContext context, int dvdiconid)
        {
            var dvdicon = context.DVDIcons
                    .Where(i => i.Id == dvdiconid).FirstOrDefault();

            return dvdicon;
        }

        public static List<DVDIcon> GetAllDVDIcons(MyDVDsContext context)
        {
            var dvdicons = context.DVDIcons.ToList();

            return dvdicons;
        }

        public static DVDIcon GetDVDIconByname(MyDVDsContext context, string iconname)
        {
            var dvdicon = context.DVDIcons
                    .Where(i => i.Name == iconname).FirstOrDefault();

            return dvdicon;
        }

        public static DVDIcon UpdateDVDIcon(MyDVDsContext context, DVDIcon newdvi)
        {
            var olddvi = GetDVDIcon(context, newdvi.Id);

            context.Entry(olddvi).CurrentValues.SetValues(newdvi);
            context.SaveChanges();

            newdvi = GetDVDIcon(context, newdvi.Id);

            return newdvi;
        }

        public static DVDIcon AddDVDIcon(MyDVDsContext context, DVDIcon newdvi)
        {
            // add it
            context.DVDIcons.Add(newdvi);

            context.SaveChanges();

            newdvi = GetDVDIcon(context, newdvi.Id);

            return newdvi;
        }

        #endregion

        #region For Screen Display

        // get all box numbers 
        public static List<int> GetAllBoxNumbers(MyDVDsContext context)
        {
           var bxns = context.StorageBoxes
                        .Select(b => b.BoxNumber)
                        .ToList();

           return bxns;
        }

        // get all case numbers
        public static List<DVDMC.AllCaseNums> GetAllCaseNumbers(MyDVDsContext context)
        {
           var cans = context.Cases
                        .Select(c => new DVDMC.AllCaseNums { bxNumber = c.StorageBox.BoxNumber, caNumber = c.CaseNumber })
                        .ToList();
           return cans;
        }

        // get all disc numbers
        public static List<DVDMC.AllDiscNums> GetAllDiscNumbers(MyDVDsContext context)
        {
           var dins = context.Discs
                        .Select(d => new DVDMC.AllDiscNums { bxNumber = d.Case.StorageBox.BoxNumber, caNumber = d.Case.CaseNumber, diNumber = d.DiscNumber })
                        .ToList();

           return dins;
        }

        // get all content numbers
        public static List<DVDMC.AllContentNums> GetAllContentNumbers(MyDVDsContext context)
        {
           var cons = context.Contents
                       .Select(x => new DVDMC.AllContentNums { bxNumber = x.Disc.Case.StorageBox.BoxNumber, caNumber = x.Disc.Case.CaseNumber, diNumber = x.Disc.Case.CaseNumber, coNumber = x.ContentNumber })
                       .ToList();

           return cons;
        }

        // get all case numbers per box
        public static List<DVDMC.AllCaseNums> GetBoxCaseNumbers(MyDVDsContext context, int boxnumber)
        {
            var cans = context.Cases
                         .Where(c => c.StorageBox.BoxNumber == boxnumber)
                         .Select(c => new DVDMC.AllCaseNums { bxNumber = c.StorageBox.BoxNumber, caNumber = c.CaseNumber })
                         .ToList();
            return cans;
        }

        // get all disc numbers per case/box
        public static List<DVDMC.AllDiscNums> GetCaseDiscNumbers(MyDVDsContext context, int boxnumber, int casenumber)
        {
            var dins = context.Discs
                         .Where(d => d.Case.StorageBox.BoxNumber == boxnumber && d.Case.CaseNumber == casenumber)
                         .Select(d => new DVDMC.AllDiscNums { bxNumber = d.Case.StorageBox.BoxNumber, caNumber = d.Case.CaseNumber, diNumber = d.DiscNumber })
                         .ToList();

            return dins;
        }

        // get all content numbers per disc/case/box
        public static List<DVDMC.AllContentNums> GetDiscContentNumbers(MyDVDsContext context, int boxnumber, int casenumber, int discnumber)
        {
            var cons = context.Contents
                         .Where(x => x.Disc.Case.StorageBox.BoxNumber == boxnumber && x.Disc.Case.CaseNumber == casenumber && x.Disc.DiscNumber == discnumber)
                        .Select(x => new DVDMC.AllContentNums { bxNumber = x.Disc.Case.StorageBox.BoxNumber, caNumber = x.Disc.Case.CaseNumber, diNumber = x.Disc.Case.CaseNumber, coNumber = x.ContentNumber })
                        .ToList();

            return cons;
        }

        #endregion

        #region Totals

        public static int TotalBoxes(MyDVDsContext context)
        {
            return context.StorageBoxes.Count();
        }

        public static int TotalCases(MyDVDsContext context)
        {
            return context.Cases.Count();
        }

        public static int TotalBoxsets(MyDVDsContext context)
        {
            return context.Cases
                .Where(x => x.IsABoxset == true)
                .Count();
        }

        public static int TotalDiscs(MyDVDsContext context)
        {
            return context.Discs.Count();
        }

        public static int TotalContents(MyDVDsContext context)
        {
            return context.Contents.Count();
        }

        #endregion
    }
}
