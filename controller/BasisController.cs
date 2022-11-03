using Logic;
using QuizDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
    public abstract class BasisController
    {
        internal DatenBank _DbContext;
        /// <summary>
        /// Konstruktor
        /// </summary>
        public BasisController(DatenBank pContext)
        {
            if (pContext is null)
            {
                throw new Exception("Kein Kontext-Factory übergeben!!");
            }
            this._DbContext = pContext;
        }

        public bool CreateEntity()
        {
            bool Result = false;
            this._DbContext.UserTab.Id = 1;
            return Result;
        }

        public bool Save()
        {
            return false;
        }

        public bool UpdateEntity()
        {
            return true;
        }

        public bool DeleteEntity(int Id = 0)
        {
            return true;
        }

        public string GetEntity(int Id = 0, bool AsTracking = false)
        {
            return "";
        }

        protected abstract void CreateDemoData();
    }
}
