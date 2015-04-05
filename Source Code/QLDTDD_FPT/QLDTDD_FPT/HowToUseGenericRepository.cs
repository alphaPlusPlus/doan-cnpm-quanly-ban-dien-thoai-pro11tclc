using QLDTDD_FPT.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDTDD_FPT
{
    class HowToUseGenericRepository
    {
        void readme()
        {
            readme

            var unitOfWork = UnitOfWork.Instance;

            // get or rows + columns of Staff table
            var staffs = unitOfWork.StaffRepository.Get();

            // ...
            // find staff by id
            Staff staff = unitOfWork.StaffRepository.GetByID("StaffId");

            // ...
            // add new staff to db
            unitOfWork.StaffRepository.Insert(new Staff {Address= "avc", Name= "abc" });
            unitOfWork.Save();

            // ...
            // update a staff
            unitOfWork.StaffRepository.Update(staff);
            unitOfWork.Save();

            // ...
            // query with 'order by' statement
            var staffsQuery = unitOfWork.StaffRepository.Get(
                orderBy: q => q.OrderBy(d => d.Name)); // lambda expression

            // ...
            // query with filter condition and 'order by' statement
            var staffsQuery2 = unitOfWork.StaffRepository.Get(
                filter: stf => stf.Name == "Chanh" && stf.Address == "Danang",
                orderBy: q => q.OrderBy(s => s.Name));

            // SPECIFIC COLUMNS
            staffsQuery2.Select(stf => new // select just StaffId and Address column
            {
                StaffId = stf.StaffId,
                Address = stf.Address
            }).ToList();
            
            // ...
            // delete by id or by object
            unitOfWork.StaffRepository.Delete("staffId");
            // or
            unitOfWork.StaffRepository.Delete(staff); // staff object
            unitOfWork.Save(); // save

            // ...
            // release resource of this unit of work
            /** 
             * PUT THIS IN OnMainForm_Closed method 
             */
            UnitOfWork.Instance.Dispose();

        }
    }
}
