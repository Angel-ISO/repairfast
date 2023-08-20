using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;
public class SucursalRepository : GenericRepository<Sucursal>, ISucursalRepository
{
    public SucursalRepository(RepairContext context) : base(context)
    {
        
    }
}