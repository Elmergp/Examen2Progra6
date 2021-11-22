using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IOrdenService
    {
        Task<DBEntity> Create(OrdenEntity entity);
        Task<DBEntity> Delete(OrdenEntity entity);
        Task<IEnumerable<OrdenEntity>> Get();
        Task<OrdenEntity> GetById(OrdenEntity entity);
        Task<DBEntity> Update(OrdenEntity entity);
    }

    public class OrdenService : IOrdenService
    {
        private readonly IDataAccess sql;

        public OrdenService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<OrdenEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<OrdenEntity, ProductoEntity>("OrdenObtener", "IdOrden,IdProducto");
                //var result = sql.QueryAsync<OrdenEntity>("OrdenObtener");

                return await result;
            }
            catch (Exception)
            {
                throw;
            }


        }

        //Metodo GetById
        public async Task<OrdenEntity> GetById(OrdenEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<OrdenEntity>("OrdenObtener", new
                { entity.IdOrden });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(OrdenEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("OrdenInsertar", new
                {
                    entity.IdProducto,
                    entity.CantidadProducto,
                    entity.Estado
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(OrdenEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("OrdenActualizar", new
                {
                    entity.IdOrden,
                    entity.IdProducto,
                    entity.CantidadProducto,
                    entity.Estado
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(OrdenEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("OrdenEliminar", new
                {
                    entity.IdOrden,
                });

                return await result;
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion
    }
}
