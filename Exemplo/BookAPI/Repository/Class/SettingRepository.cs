using CVAPI.Context;
using CVAPI.Models;
using CVAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Repository.Class
{
    public class SettingRepository : ISettingRepository
    {
        private readonly ApplicationContext db;
        public SettingRepository(ApplicationContext ctx)
        {
            db = ctx;
        }

        public async Task<Setting> Add(Setting setting)
        {
            db.Settings.Add(setting);
            await db.SaveChangesAsync();
            return setting;
        }

        public async Task<Setting> Edit(Setting setting)
        {
            db.Settings.Update(setting);
            await db.SaveChangesAsync();
            return setting;
        }

        public async Task<Setting> Find(int id)
        {
            var result = await db.Settings.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<Setting>> GetAllByDelivery()
        {
            var result = await db.Settings.Where(x => x.ResignationDate == new DateTime()).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Setting>> GetAll()
        {
            var result = await db.Settings.ToListAsync();
            return result;
        }

        public async Task Delete(int id)
        {
            var result = await db.Settings.Where(x => x.Id == id).FirstOrDefaultAsync();
            db.Settings.Remove(result);
            await db.SaveChangesAsync();
        }
    }
}