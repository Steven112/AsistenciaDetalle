using Microsoft.VisualStudio.TestTools.UnitTesting;
using AsistenciaDetalle.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsistenciaDetalle.Entidades;

namespace AsistenciaDetalle.BLL.Tests
{
    [TestClass()]
    public class GenericDetalleBLLTests
    {
        [TestMethod()]
        public void GenericDetalleBLLTest()
        {
            bool paso;
            GenericDetalleBLL<Asignatura> Repository = new GenericDetalleBLL<Asignatura>();
            Asignatura asignatura = new Asignatura();
            asignatura.AsignaturaId = 0;
            asignatura.Nombre = "Starlyn";
           
            paso = Repository.Guardar(asignatura);

            bool paso1;
            GenericDetalleBLL<EstudiantesDetalle> Repository1 = new GenericDetalleBLL<EstudiantesDetalle>();
            EstudiantesDetalle estudiantes = new EstudiantesDetalle();
            estudiantes.EstudianteId = 0;
            estudiantes.Nombres = "Starlyn";

            paso1 = Repository1.Guardar(estudiantes);

            Assert.AreEqual(paso1, true);
        }



        [TestMethod()]
        public void GuardarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}