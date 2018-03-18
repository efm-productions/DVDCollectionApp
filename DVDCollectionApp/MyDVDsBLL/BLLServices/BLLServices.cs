using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;
using MyDVDsDAL.DALServices;

using DVDMC;

using System.Drawing;
using System.IO;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;

namespace MyDVDsBLL.BLLServices
{
    public class BLLServices
    {
        #region constants

        private const int CDCASEICON = 3;
        private const int DVDCASEICON = 4;
        private const int DVDDISCICON = 6;

        #endregion

        private MyDVDsContext context;

        // ctor
        public BLLServices()
        {
            ClearContext();
        }

        public void ChkContext()
        {
            if (context == null)
            {
                SetContext();
            }
        }

        public void SetContext()
        {
            context = new MyDVDsContext();
        }

        public void ClearContext()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }

        #region Box

        // ADD a new CD Box - no related records
        private StorageBox AddCDBox()
        {
            StorageBox sb = DALServices.AddABox(context, "CD");
            return sb;
        }

        // ADD a new DVD Box - no related records
        private StorageBox AddDVDBox()
        {
            StorageBox sb = DALServices.AddABox(context, "DVD");
            return sb;
        }

        // get next available box # for adding a new box
        public int GetNextBoxNumber()
        {
            int nxtbxn = DALServices.GetNextBoxNumber(context);

            return nxtbxn;
        }

        // get a box by number
        public StorageBox GetBox(int boxnumber)
        {
            StorageBox sb = DALServices.GetBox(context, boxnumber);

            return sb;
        }

        #endregion

        #region Case

        // ADD the next Case to a specific box
        public Case AddNextCase(int boxnum)
        {
            Case ca = DALServices.AddNextCase(context, boxnum);

            return ca;
        }

        // get next available case # for adding a new case to the box object
        public int GetNextCaseNumber(StorageBox box)
        {
            int nxtcasn = DALServices.GetNextCaseNumber(box);

            return nxtcasn;
        }

        // get a case by number
        public Case GetCase(int boxnumber, int casenumber)
        {
            Case ca = DALServices.GetCase(context, boxnumber, casenumber);

            return ca;
        }

        #endregion

        #region Disc

        // ADD the next Disc to a specific case/box
        public Disc AddNextDisc(int boxnum, int casenum)
        {
            Disc di = DALServices.AddNextDisc(context, boxnum, casenum);

            return di;
        }

        // get next available disc # for adding a new disc to the case object
        public int GetNextDiscNumber(Case ca)
        {
            int nxtdscn = DALServices.GetNextDiscNumber(ca);

            return nxtdscn;
        }

        // get a disc by number
        public Disc GetDisc(int boxnumber, int casenumber, int discnumber)
        {
            Disc di = DALServices.GetDisc(context, boxnumber, casenumber, discnumber);

            return di;
        }

        #endregion

        #region Content

        // ADD the next Content to a specific disc/case/box
        public Content AddNextContent(int boxnum, int casenum, int discnum)
        {
            Content co = DALServices.AddNextContent(context, boxnum, casenum, discnum);

            return co;
        }

        // get next available content # for adding a new content to the disc object
        public int GetNextContentNumber(Disc di)
        {
            int nxtcntn = DALServices.GetNextContentNumber(di);

            return nxtcntn;
        }

        // get a content by number
        public Content GetContent(int boxnumber, int casenumber, int discnumber, int contentnumber)
        {
            Content co = DALServices.GetContent(context, boxnumber, casenumber, discnumber, contentnumber);

            return co;
        }

        public Content GetContentById(int Id)
        {
            Content co = DALServices.GetContentById(context, Id);

            return co;
        }

        public List<AllContentForGrid> GetAllContents()
        {
            List<AllContentForGrid> allCntL = new List<AllContentForGrid>();

            allCntL = DALServices.GetAllContents(context);

            return allCntL;
        }

        public List<Content> SearchForTitle(string title)
        {
            ChkContext();

            var coList = DALServices.SearchForTitle(context, title);

            return coList;
        }

        #endregion

        #region Lookups

        public Genre GetGenre(int genreid)
        {
            Genre g = new Genre();

            using (context)
            {
                g = DALServices.GetGenre(context, genreid);
            }
            ClearContext();
            return g;
        }

        public List<Genre> GetAllGenres()
        {
            List<Genre> gL = new List<Genre>();

            ChkContext();
            using (context)
            {
                gL = DALServices.GetAllGenres(context);
            }
            ClearContext();
            return gL;
        }

        public Genre UpdateGenre(Genre newgenre)
        {
            Genre g = new Genre();

            ChkContext();
            using (context)
            {
                g = DALServices.UpdateGenre(context, newgenre);
            }
            ClearContext();
            return g;
        }

        public Genre AddGenre(Genre newgnr)
        {
            Genre gnr = new Genre();

            ChkContext();
            using (context)
            {
                gnr = DALServices.AddGenre(context, newgnr);
            }
            ClearContext();
            return gnr;
        }

        public Genre GetGenreByName(string name)
        {
            Genre gnr = new Genre();

            ChkContext();
            using (context)
            {
                gnr = DALServices.GetGenreByname(context, name);
            }
            ClearContext();
            return gnr;
        }

        public bool IsGenreDuplicate(string name)
        {
            ChkContext();
            bool b = DALServices.IsGenreDuplicate(context, name);
            ClearContext();
            return b;
        }

        public int DeleteGenre(int id)
        {
            var gnr = new Genre();
            gnr.Id = id;

            ChkContext();
            int results = DALServices.DeleteGenre(context, gnr);
            ClearContext();
            return results;
        }

        public List<AllGenresForGrid> GetAllGenresForGrid()
        {
            List<AllGenresForGrid> allGnrL = new List<AllGenresForGrid>();

            allGnrL = DALServices.GetAllGenresForGrid(context);

            return allGnrL;
        }

        public Rating GetRating(int ratingid)
        {
            Rating r = new Rating();

            ChkContext();
            using (context)
            {
                r = DALServices.GetRating(context, ratingid);
            }
            ClearContext();
            return r;
        }

        public List<Rating> GetAllRatings()
        {
            List<Rating> rL = new List<Rating>();

            ChkContext();
            using (context)
            {
                rL = DALServices.GetAllRatings(context);
            }
            ClearContext();
            return rL;
        }

        public Rating UpdateRating(Rating newrating)
        {
            Rating rating = new Rating();

            ChkContext();
            using (context)
            {
                rating = DALServices.UpdateRating(context, newrating);
            }
            ClearContext();
            return rating;
        }

        public Rating AddRating(Rating newgnr)
        {
            Rating gnr = new Rating();

            ChkContext();
            using (context)
            {
                gnr = DALServices.AddRating(context, newgnr);
            }
            ClearContext();
            return gnr;
        }


        public Rating GetRatingByCod(string mpaacode)
        {
            Rating gnr = new Rating();

            ChkContext();
            using (context)
            {
                gnr = DALServices.GetRatingByCode(context, mpaacode);
            }
            ClearContext();
            return gnr;
        }

        public bool IsRatingDuplicate(string name)
        {
            ChkContext();
            bool b = DALServices.IsRatingDuplicate(context, name);
            ClearContext();
            return b;
        }

        public int DeleteRating(int id)
        {
            var gnr = new Rating();
            gnr.Id = id;

            ChkContext();
            int results = DALServices.DeleteRating(context, gnr);
            ClearContext();
            return results;
        }

        public List<AllRatingsForGrid> GetAllRatingsForGrid()
        {
            List<AllRatingsForGrid> allGnrL = new List<AllRatingsForGrid>();

            allGnrL = DALServices.GetAllRatingsForGrid(context);

            return allGnrL;
        }

        public DVDIcon GetDVDIcon(int dvdiconid)
        {
            DVDIcon dvi = new DVDIcon();

            ChkContext();
            using (context)
            {
                dvi = DALServices.GetDVDIcon(context, dvdiconid);
            }
            ClearContext();
            return dvi;
        }

        public List<DVDIcon> GetAllDVDIcons()
        {
            List <DVDIcon> dviL = new List<DVDIcon>();

            ChkContext();
            using (context)
            {
                dviL = DALServices.GetAllDVDIcons(context);
            }
            ClearContext();
            return dviL;
        }

        public DVDIcon GetDVDIconByName(string iconname)
        {
            DVDIcon dvi = new DVDIcon();

            ChkContext();
            using (context)
            {
                dvi = DALServices.GetDVDIconByname(context, iconname);
            }
            ClearContext();
            return dvi;
        }

        public DVDIcon UpdateDVDIcon(DVDIcon newdvi)
        {
            DVDIcon dvi = new DVDIcon();

            ChkContext();
            using (context)
            {
                dvi = DALServices.UpdateDVDIcon(context, newdvi);
            }
            ClearContext();
            return dvi;
        }

        public DVDIcon AddDVDIcon(DVDIcon newdvi)
        {
            DVDIcon dvi = new DVDIcon();

            ChkContext();
            using (context)
            {
                dvi = DALServices.AddDVDIcon(context, newdvi);
            }
            ClearContext();
            return dvi;
        }

        #endregion

        #region For Screen Display

        // get all box numbers 
        public List<int> GetAllBoxNumbers()
        {
                var bxnsList = DALServices.GetAllBoxNumbers(context);
                return bxnsList;
        }

        // get all case numbers
        public List<DVDMC.AllCaseNums> GetAllCaseNumbers()
        {
                var cansList = DALServices.GetAllCaseNumbers(context);
                return cansList;
        }

        // get all disc numbers
        public List<DVDMC.AllDiscNums> GetAllDiscNumbers()
        {
                var dinsList = DALServices.GetAllDiscNumbers(context);
                return dinsList;
        }

        // get all content numbers
        public List<DVDMC.AllContentNums> GetAllContentNumbers()
        {
            var consList = DALServices.GetAllContentNumbers(context);

            return consList;
        }

        // get all case numbers per box
        public List<DVDMC.AllCaseNums> GetBoxCaseNumbers(int boxnumber)
        {
                var cans = DALServices.GetBoxCaseNumbers(context, boxnumber);
                return cans;
        }

        // get all disc numbers per case/box
        public List<DVDMC.AllDiscNums> GetCaseDiscNumbers(int boxnumber, int casenumber)
        {
                var dins = DALServices.GetCaseDiscNumbers(context, boxnumber, casenumber);
                return dins;
        }

        // get all content numbers per disc/case/box
        public List<DVDMC.AllContentNums> GetDiscContentNumbers(int boxnumber, int casenumber, int discnumber)
        {
                var cons = DALServices.GetDiscContentNumbers(context, boxnumber, casenumber, discnumber);
                return cons;
        }

        #endregion

        #region Utilities

        public List<Case> GetCasesFromBox(StorageBox box)
        {
            List<Case> cases = new List<Case>();

            if (box.TotalCases > 0)
            {
               cases = box.Cases.ToList();
            }
            else
            {
               cases.Clear();
            }

            return cases;
        }

        public List<Disc> GetDiscsFromCase(Case ca)
        {
            List<Disc> discs = new List<Disc>();

            if (ca.TotalDiscs > 0)
            {
               discs = ca.Discs.ToList();
            }

            return discs;
        }

        public List<Content> GetContentsFromDisc(Disc di)
        {
            List<Content> contents = new List<Content>();

            if (di.TotalContents > 0)
            {
                contents = di.Contents.ToList();
            }

            return contents;
        }

        // convert byte array to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        // convert image to byte array
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        #endregion

        #region Totals

        public int TotalBoxes()
        {
            var totals = DALServices.TotalBoxes(context);
            return totals;
        }

        public int TotalCases()
        {
            var totals = DALServices.TotalCases(context);
            return totals;
        }

        public int TotalBoxsets()
        {
             var totals = DALServices.TotalBoxsets(context);
             return totals;
        }

        public int TotalDiscs()
        {
             var totals = DALServices.TotalDiscs(context);
             return totals;
        }

        public int TotalContents()
        {
            var totals = DALServices.TotalContents(context);
            return totals;
        }

        #endregion
    }
}