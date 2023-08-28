using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Repository;

    public class PaisRepository : GenericRepositoryA<Persona>, IPersonaInterface
    {
        public readonly  BodegaContext _context;
        public PaisRepository(BodegaContext context) : base(context){
            _context = context;
        }
        public override async Task<IEnumerable<Persona>> GetAllAsync(){
            return await _context.Personas.ToListAsync();
        }
        public override async Task<Persona>  GetByIdAsync(int id){
            return await _context.Personas.FirstOrDefaultAsync(p => p.Id == id);
        }
    }