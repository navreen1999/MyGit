using EmployeeMVC.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Services
{
    public class IRepoServices : IRepo<Personal>
    {
        private PersonalContext _context;
        private ILogger<IRepoServices> _logger;
        

        public IRepoServices()
        {

        }
        public IRepoServices(PersonalContext context,ILogger<IRepoServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Personal t)
        {
            try
            {
                _context.Personals.Add(t);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }

        public void Delete(Personal t)
        {
            try
            {
                _context.Personals.Remove(t);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }

        public Personal Get(int id)
        {
            try
            {
                Personal personal = _context.Personals.FirstOrDefault(a => a.Id == id);
                return personal;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public IEnumerable<Personal> GetAll()
        {
            try
            {
                if (_context.Personals.Count() == 0)
                    return null;
                return _context.Personals.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public void Update(int id, Personal t)
        {
            Personal personal = Get(id);
            if (personal != null)
            {
                personal.Name = t.Name;
                personal.NoticePeriod = t.NoticePeriod;
                personal.Qualification = t.Qualification;
                personal.IsEmployed = t.IsEmployed;
                personal.CurrentCTC = t.CurrentCTC;
            }
            _context.SaveChanges();
        }
    }
    
}
