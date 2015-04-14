using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDTDD_FPT.Database
{
    public class UnitOfWork : IDisposable
    {
        private static UnitOfWork _instance;
        public static UnitOfWork Instance
        {
            get
            {
                return _instance ?? (_instance = new UnitOfWork());
            }
        }

        // db context
        private SysDbContext _context;
        private UnitOfWork()
        {
            _context = SysDbContext.Instance;
        }

        // repositories
        private GenericRepository<Asset> _assetRepo;
        private GenericRepository<Phone> _phoneRepo;
        private GenericRepository<Export> _exportRepo;
        private GenericRepository<Import> _importRepo;
        private GenericRepository<Order> _orderRepo;
        private GenericRepository<Staff> _staffRepo;
        private GenericRepository<TimeBook> _timebookRepo;
        private GenericRepository<Distributor> _distrRepo;
        private GenericRepository<OperatingSystem> _operatingSysRepo;
        private GenericRepository<Manufacturer> _manuRepo;
        private GenericRepository<Color> _colorRepo;

        public GenericRepository<Asset> AssetRepository
        {
            get
            {
                return _assetRepo ?? (_assetRepo = new GenericRepository<Asset>(_context));
            }
        }

        public GenericRepository<Phone> PhoneRepository
        {
            get
            {
                return _phoneRepo ?? (_phoneRepo = new GenericRepository<Phone>(_context));
            }
        }

        public GenericRepository<Export> ExportRepository
        {
            get
            {
                return _exportRepo ?? (_exportRepo = new GenericRepository<Export>(_context));
            }
        }

        public GenericRepository<Import> ImportRepository
        {
            get
            {
                return _importRepo ?? (_importRepo = new GenericRepository<Import>(_context));
            }
        }

        public GenericRepository<Order> OrderRepository
        {
            get
            {
                return _orderRepo ?? (_orderRepo = new GenericRepository<Order>(_context));
            }
        }

        public GenericRepository<Staff> StaffRepository
        {
            get
            {
                return _staffRepo ?? (_staffRepo = new GenericRepository<Staff>(_context));
            }
        }

        public GenericRepository<TimeBook> TimeBookRepository
        {
            get
            {
                return _timebookRepo ?? (_timebookRepo = new GenericRepository<TimeBook>(_context));
            }
        }

        public GenericRepository<Distributor> DistributorRepository
        {
            get
            {
                return _distrRepo ?? (_distrRepo = new GenericRepository<Distributor>(_context));
            }
        }

        public GenericRepository<OperatingSystem> OperatingSystemRepository
        {
            get
            {
                return _operatingSysRepo ?? (_operatingSysRepo = new GenericRepository<OperatingSystem>(_context));
            }
        }

        public GenericRepository<Manufacturer> ManufacturerRepository
        {
            get
            {
                return _manuRepo ?? (_manuRepo = new GenericRepository<Manufacturer>(_context));
            }
        }

        public GenericRepository<Color> ColorRepository
        {
            get
            {
                return _colorRepo ?? (_colorRepo = new GenericRepository<Color>(_context));
            }
        }

        // saving context
        public void Save()
        {
            _context.SaveChanges();
        }

        //disposing
        private bool _disposed = false;

        private void dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
