
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    public class ProductsList
    {
        List<Producto> products = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop HP Pavilion", Descripcion = "Laptop", Precio = 899.30m, Stock = 15, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 1, 10) },
        new Producto { Id = 2, Nombre = "iPhone 14 Pro", Descripcion = "Smartphone 128GB", Precio = 999.00m, Stock = 20, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 2, 15) },
        new Producto { Id = 3, Nombre = "Samsung Galaxy S23", Descripcion = "Smartphone Android", Precio = 1099.00m, Stock = 10, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 3, 5) },
        new Producto { Id = 4, Nombre = "Smart TV LG 55\"", Descripcion = "Televisor 4K", Precio = 799.99m, Stock = 8, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 4, 20) },
        new Producto { Id = 5, Nombre = "Nintendo Switch", Descripcion = "Consola de videojuegos portátil y de sobremesa", Precio = 299.99m, Stock = 25, Categoria = "Juguetes", FechaCreacion = new DateTime(2023, 5, 12) },
        new Producto { Id = 6, Nombre = "Sofá de cuero", Descripcion = "Sofá de cuero", Precio = 499.39m, Stock = 5, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 6, 18) },
        new Producto { Id = 7, Nombre = "Mesa de centro", Descripcion = "Mesa de centro", Precio = 149.99m, Stock = 12, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 7, 22) },
        new Producto { Id = 8, Nombre = "Zapatillas Nike Air Max", Descripcion = "Zapatillas deportivas con tecnología Air Max", Precio = 129.19m, Stock = 30, Categoria = "Ropa", FechaCreacion = new DateTime(2023, 8, 30) },
        new Producto { Id = 9, Nombre = "Camiseta Nike de Lebron James Jr", Descripcion = "Camiseta deportiva de algodón, talla M", Precio = 29.29m, Stock = 50, Categoria = "Ropa", FechaCreacion = new DateTime(2023, 9, 10) },
        new Producto { Id = 10, Nombre = "Pelota de fútbol", Descripcion = "Pelota de fútbol oficial tamaño 5", Precio = 19.99m, Stock = 40, Categoria = "Deportes", FechaCreacion = new DateTime(2023, 10, 5) },
        new Producto { Id = 11, Nombre = "Impresora HP LaserJet", Descripcion = "Impresora láser monocromática, 20 ppm", Precio = 199.99m, Stock = 7, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 11, 1) },
        new Producto { Id = 12, Nombre = "Tablet Samsung Galaxy Tab", Descripcion = "Tablet con pantalla de 10.4\", 64GB", Precio = 249.59m, Stock = 18, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 12, 15) },
        new Producto { Id = 13, Nombre = "Cafetera Nespresso", Descripcion = "Cafetera de cápsulas, color rojo", Precio = 149.99m, Stock = 22, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 1, 25) },
        new Producto { Id = 14, Nombre = "Robot aspirador Xiaomi", Descripcion = "Robot aspirador", Precio = 299.39m, Stock = 9, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 2, 10) },
        new Producto { Id = 15, Nombre = "Reloj inteligente Garmin", Descripcion = "Reloj inteligente con GPS y monitor de ritmo cardíaco", Precio = 199.99m, Stock = 14, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 3, 20) },
        new Producto { Id = 16, Nombre = "Auriculares Sony WH-1000XM4", Descripcion = "Auriculares inalámbricos con cancelación de ruido", Precio = 349.19m, Stock = 11, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 4, 5) },
        new Producto { Id = 17, Nombre = "Maleta North Face", Descripcion = "Maleta resistente al agua, 30L", Precio = 89.99m, Stock = 25, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2023, 5, 18) },
        new Producto { Id = 18, Nombre = "Cámara Canon EOS Pro", Descripcion = "Cámara 30.3MP", Precio = 1999.99m, Stock = 3, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 6, 22) },
        new Producto { Id = 19, Nombre = "Teclado mecánico Logitech Pro", Descripcion = "Teclado gaming", Precio = 129.99m, Stock = 20, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 7, 30) },
        new Producto { Id = 20, Nombre = "Monitor Dell 27\"", Descripcion = "Monitor QHD, 144Hz, 1ms", Precio = 399.99m, Stock = 6, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 8, 10) },
        new Producto { Id = 21, Nombre = "Bicicleta de montaña", Descripcion = "Bicicleta de montaña", Precio = 499.99m, Stock = 8, Categoria = "Deportes", FechaCreacion = new DateTime(2023, 9, 5) },
        new Producto { Id = 22, Nombre = "Mesa de escritorio", Descripcion = "Mesa de escritorio de madera, 120x60cm", Precio = 99.99m, Stock = 15, Categoria = "General", FechaCreacion = new DateTime(2023, 10, 12) },
        new Producto { Id = 23, Nombre = "Silla ergonómica", Descripcion = "Silla de oficina", Precio = 199.28m, Stock = 10, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 11, 18) },
        new Producto { Id = 24, Nombre = "Altavoz Bluetooth JBL", Descripcion = "Altavoz portátil resistente al agua", Precio = 129.99m, Stock = 25, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 12, 22) },
        new Producto { Id = 25, Nombre = "Cargador inalámbrico", Descripcion = "Cargador inalámbrico Qi, 10W", Precio = 29.99m, Stock = 50, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 1, 30) },
        new Producto { Id = 26, Nombre = "Licuadora Oster", Descripcion = "Licuadora de 600W", Precio = 49.99m, Stock = 20, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 2, 5) },
        new Producto { Id = 27, Nombre = "Batidora KitchenAid", Descripcion = "Batidora de pie, 5 velocidades", Precio = 299.99m, Stock = 8, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 3, 10) },
        new Producto { Id = 28, Nombre = "Horno", Descripcion = "Horno tostador de 6 rebanadas, color plateado", Precio = 59.99m, Stock = 12, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 4, 15) },
        new Producto { Id = 29, Nombre = "Cafetera", Descripcion = "Cafetera italiana", Precio = 39.00m, Stock = 30, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 5, 20) },
        new Producto { Id = 30, Nombre = "Juego de sartenes", Descripcion = "Juego de sartenes", Precio = 79.99m, Stock = 18, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 6, 25) },
        new Producto { Id = 31, Nombre = "Set de cuchillos", Descripcion = "Set de cuchillos", Precio = 89.37m, Stock = 10, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 7, 30) },
        new Producto { Id = 32, Nombre = "Vajilla", Descripcion = "Vajilla para 6 personas, color blanco", Precio = 129.99m, Stock = 7, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 8, 5) },
        new Producto { Id = 33, Nombre = "Cortina blackout", Descripcion = "Cortina blackout, 140x240cm, color gris", Precio = 49.99m, Stock = 25, Categoria = "General", FechaCreacion = new DateTime(2023, 9, 10) },
        new Producto { Id = 34, Nombre = "Almohada", Descripcion = "Almohada ortopédica de memoria viscoelástica", Precio = 39.99m, Stock = 40, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 10, 15) },
        new Producto { Id = 35, Nombre = "Colchón", Descripcion = "Colchón inflable para invitados, tamaño queen", Precio = 89.99m, Stock = 15, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 11, 20) },
        new Producto { Id = 36, Nombre = "Cuna", Descripcion = "Cuna portátil para bebé, color azul", Precio = 129.99m, Stock = 10, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 12, 25) },
        new Producto { Id = 37, Nombre = "Silla", Descripcion = "Silla de paseo", Precio = 199.99m, Stock = 8, Categoria = "General", FechaCreacion = new DateTime(2023, 1, 30) },
        new Producto { Id = 38, Nombre = "Estante para zapatos", Descripcion = "Estante para zapatos", Precio = 299.99m, Stock = 5, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2023, 2, 5) },
        new Producto { Id = 39, Nombre = "Bocina JBL", Descripcion = "Bocina de alto volumen y calidad", Precio = 379.99m, Stock = 20, Categoria = "Audio", FechaCreacion = new DateTime(2023, 3, 10) },
        new Producto { Id = 40, Nombre = "Termómetro digital", Descripcion = "Termómetro infrarrojo", Precio = 29.00m, Stock = 50, Categoria = "General", FechaCreacion = new DateTime(2023, 4, 15) },
        new Producto { Id = 41, Nombre = "Báscula", Descripcion = "Báscula digital para baño, capacidad 150kg", Precio = 19.99m, Stock = 30, Categoria = "General", FechaCreacion = new DateTime(2023, 5, 20) },
        new Producto { Id = 42, Nombre = "Aspiradora", Descripcion = "Aspiradora manual", Precio = 49.99m, Stock = 25, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 6, 25) },
        new Producto { Id = 43, Nombre = "Purificador de aire", Descripcion = "Purificador de aire con filtro HEPA", Precio = 199.54m, Stock = 10, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 7, 30) },
        new Producto { Id = 44, Nombre = "Ventilador de torre", Descripcion = "Ventilador de torre", Precio = 69.00m, Stock = 15, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 8, 5) },
        new Producto { Id = 45, Nombre = "Calefactor portátil", Descripcion = "Calefactor portátil de 1500W", Precio = 79.99m, Stock = 12, Categoria = "General", FechaCreacion = new DateTime(2023, 9, 10) },
        new Producto { Id = 46, Nombre = "Humidificador ultrasónico", Descripcion = "Humidificador ultrasónico, 2.5L", Precio = 59.99m, Stock = 20, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 10, 15) },
        new Producto { Id = 47, Nombre = "Lámpara de escritorio", Descripcion = "Lámpara de escritorio LED, ajustable", Precio = 39.47m, Stock = 30, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 11, 20) },
        new Producto { Id = 48, Nombre = "Reloj despertador", Descripcion = "Reloj despertador", Precio = 29.99m, Stock = 40, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 12, 25) },
        new Producto { Id = 49, Nombre = "Cámara de vigilancia", Descripcion = "Cámara de vigilancia", Precio = 99.99m, Stock = 10, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 1, 30) }
        };



        public void EjerciciosLINQ()
        {

            // 1. Obtener todos los productos de la lista.
            #region

            foreach (var productos in products.Select(p => p))
            {
                Console.WriteLine($" {productos.Id}  | {productos.Descripcion} | {productos.Nombre} | {productos.Precio}  {productos.FechaCreacion} |  {productos.Stock} |  {productos.Categoria}");
                Console.WriteLine();
            }

            #endregion

            //2. Obtener los nombres de todos los productos.

            #region
            foreach (var obtenerNombres in products.Select(n => n.Nombre))
            {
                Console.WriteLine(obtenerNombres);
            }
            #endregion

            //3. Obtener los productos cuyo precio sea mayor a 500

            #region
            foreach (var mayor500 in products.Where(p => p.Precio > 500))
                {
                    Console.WriteLine($" {mayor500.Id}  | {mayor500.Descripcion} | {mayor500.Nombre} | {mayor500.Precio}  {mayor500.FechaCreacion} |  {mayor500.Stock} |  {mayor500.Categoria}");
                }

            #endregion


            // 4. Obtener los productos con stock menor a 10.
            #region
            foreach (var stockMenor10 in products.Where(p => p.Stock < 10))
                {
                    Console.WriteLine($" {stockMenor10.Id}  | {stockMenor10.Descripcion} | {stockMenor10.Nombre} | {stockMenor10.Precio}  {stockMenor10.FechaCreacion} |  {stockMenor10.Stock} |  {stockMenor10.Categoria}");
                }
            #endregion

            // 5. Obtener los productos de la categoría "Electrónica"

            #region
            foreach (var categoriaElectronica in products.Where(p => p.Categoria == "Electrónica"))
            {
                Console.WriteLine($" {categoriaElectronica.Id}  | {categoriaElectronica.Descripcion} | {categoriaElectronica.Nombre} | {categoriaElectronica.Precio}  {categoriaElectronica.FechaCreacion} |  {categoriaElectronica.Stock} |  {categoriaElectronica.Categoria}");
            }

            #endregion

            // 6. Obtener los productos cuyo nombre comience con la letra 'L'

            #region
            foreach (var productoConL in products.Where(p => p.Nombre.StartsWith("L")))
            {
                Console.WriteLine($" {productoConL.Id}  | {productoConL.Descripcion} | {productoConL.Nombre} | {productoConL.Precio}  {productoConL.FechaCreacion} |  {productoConL.Stock} |  {productoConL.Categoria}");
            }

            #endregion

            // 7. Obtener los productos cuyo precio esté entre 100 y 500.

            #region
            foreach (var precioEntre in products.Where(p => p.Precio <= 500 & p.Precio >= 100))
            {
                Console.WriteLine($" {precioEntre.Id}  | {precioEntre.Descripcion} | {precioEntre.Nombre} | {precioEntre.Precio}  {precioEntre.FechaCreacion} |  {precioEntre.Stock} |  {precioEntre.Categoria}");
            }
            #endregion

            // 8. Obtener los productos ordenados por precio ascendente.

            #region

            var precioAsc = from a in products
                            orderby a.Precio ascending
                            select a;

            foreach (var item in precioAsc)
            {
                Console.WriteLine($" {item.Id}  | {item.Descripcion} | {item.Nombre} | {item.Precio}  {item.FechaCreacion} |  {item.Stock} |  {item.Categoria}");
            }
            #endregion

            // 9. Obtener los productos ordenados por precio descendente.
            #region
            var precioDesc = from a in products
                             orderby a.Precio descending
                             select a;

            foreach (var item in precioDesc)
            {
                Console.WriteLine($" {item.Id}  | {item.Descripcion} | {item.Nombre} | {item.Precio}  {item.FechaCreacion} |  {item.Stock} |  {item.Categoria}");
            }
            #endregion

            // 10. Obtener los productos ordenados por nombre en orden alfabético

            #region
            var nombreAlf = from n in products
                            orderby n.Nombre
                            select n;

            foreach (var item in nombreAlf)
            {
                Console.WriteLine($" {item.Id}  | {item.Descripcion} | {item.Nombre} | {item.Precio}  {item.FechaCreacion} |  {item.Stock} |  {item.Categoria}");
            }

            #endregion

            // 11. Obtener los productos ordenados por stock de mayor a menor

            #region
            var ordenarStock = from o in products
                               orderby o.Stock descending
                               select o;

            foreach (var stock in ordenarStock)
            {

                Console.WriteLine($" {stock.Id}  | {stock.Descripcion} | {stock.Nombre} | {stock.Precio}  {stock.FechaCreacion} |  {stock.Stock} |  {stock.Categoria}");

            }
            #endregion

            //12. Obtener los primeros 5 productos más caros.

            #region

            var productosCaros = (from p in products
                                  orderby p.Precio descending
                                  select p).Take(5);


            foreach (var productoCaro in productosCaros)
            {
                Console.WriteLine($" {productoCaro.Id}  | {productoCaro.Descripcion} | {productoCaro.Nombre} | {productoCaro.Precio}  {productoCaro.FechaCreacion} |  {productoCaro.Stock} |  {productoCaro.Categoria}");
            }

            #endregion

            //13. Obtener los 10 productos con menor stock.

            #region
            var productoStock10 = (from p in products
                                   orderby p.Stock ascending
                                   select p).Take(10);

            foreach (var stockMenor in productoStock10)
            {
                Console.WriteLine($" {stockMenor.Id}  | {stockMenor.Descripcion} | {stockMenor.Nombre} | {stockMenor.Precio}  {stockMenor.FechaCreacion} |  {stockMenor.Stock} |  {stockMenor.Categoria}");
            }

            #endregion

            //14. Obtener la cantidad total de productos en la lista
            #region
            var contarProductos = (from c in products
                                   select c).Count().ToString();

            foreach (var numeroProductos in contarProductos)
            {
                Console.Write(numeroProductos);
            }
            #endregion

            // 15. Obtener la suma de todos los precios de los productos

            #region
            foreach (var sumarPrecio in products.Sum(p => p.Precio).ToString())
            {
                Console.Write(sumarPrecio);
            };

            #endregion

            // 16. Obtener el precio promedio de los productos
            #region
            foreach (var precioPromedio in products.Average(p => p.Precio).ToString())
            {
                Console.Write(precioPromedio);
            }


            #endregion

            // 17. Obtener el producto más caro
            #region

            var productoCaro = (from p in products
                                orderby p.Precio descending
                                select p).Take(1).ToList();

            foreach (var masCaro in productoCaro)
            {
                Console.WriteLine($" {masCaro.Id}  | {masCaro.Descripcion} | {masCaro.Nombre} | {masCaro.Precio}  {masCaro.FechaCreacion} |  {masCaro.Stock} |  {masCaro.Categoria}");
            }
            #endregion

            //18. Obtener el producto más barato.
            #region
            var productoBarato = (from p in products
                                  orderby p.Precio ascending
                                  select p).Take(1).ToList();

            foreach (var masBarato in productoBarato)
            {
                Console.WriteLine($" {masBarato.Id}  | {masBarato.Descripcion} | {masBarato.Nombre} | {masBarato.Precio}  {masBarato.FechaCreacion} |  {masBarato.Stock} |  {masBarato.Categoria}");
            }
            #endregion

            // 19. Verificar si hay algún producto con precio mayor a 1000.

            #region

            bool productoMayor1000 = products.Any(p => p.Precio > 1000);

            if (productoMayor1000)
            {
                Console.WriteLine("Hay un producto con precio mayor a 1000");
            }
            else
            {
                Console.WriteLine("No hay un producto con precio mayor a 1000");
            }

            #endregion


            //20. Verificar si todos los productos tienen stock mayor a 5

            #region

            bool stockMayorA5 = products.All(p => p.Stock > 5);

            if (!stockMayorA5)
            {
                Console.WriteLine("No todos los productos tienen mas de 5 unidades en stock");
            }
            #endregion

            //21. Contar cuántos productos hay en la categoría "Audio"
            #region

            var cantidadCatAudio = products.Where(p => p.Categoria == "Audio").Count();

            Console.WriteLine($"La cantidad de productos en la categoria audio son {cantidadCatAudio}");

            #endregion

            // 22. Agrupar los productos por categoría.
            #region
            var productosCategoria = from p in products
                                     orderby p.Categoria
                                     select p;

            foreach (var agruparProductos in productosCategoria)
            {
                Console.WriteLine($" {agruparProductos.Id}  | {agruparProductos.Descripcion} | {agruparProductos.Nombre} | {agruparProductos.Precio}  {agruparProductos.FechaCreacion} |  {agruparProductos.Stock} |  {agruparProductos.Categoria}");
            }
            #endregion

            // 23. Obtener la categoría con más productos.

            #region

            foreach (var categoriaMayor in products.GroupBy(p => p.Categoria).OrderByDescending(o => o.Count()).FirstOrDefault())

            {
                Console.WriteLine($"{categoriaMayor.Categoria} | {categoriaMayor.Nombre} | {categoriaMayor.Precio}");
            }
            #endregion

            //24. Obtener el stock total de todos los productos
            #region

            foreach (var sumarStock in products.Sum(s => s.Stock).ToString())
            {

                Console.Write(sumarStock);
            }

            #endregion

            // 25. Obtener el producto con el nombre más largo.

            #region

            var longitudNombre = products.Max(p => p.Nombre.Length);
            var productoMasLargo = products.FirstOrDefault(p => p.Nombre.Length == longitudNombre);

            Console.WriteLine($"{productoMasLargo.Nombre} | {productoMasLargo.Descripcion} | {productoMasLargo.Precio}");

            #endregion

            // 26. Obtener el producto con la descripción más corta
            #region

            //var longitudDescripcion = products.Min(p => p.Descripcion.Length);
            //var descripcionCorta = products.FirstOrDefault(p =>p.Descripcion.Length == longitudDescripcion);

            //Console.WriteLine($"{descripcionCorta.Nombre} | {descripcionCorta.Descripcion} | {descripcionCorta.Precio}");
            #endregion

            // 27. Filtrar los productos cuya descripción contenga la palabra "pantalla"

            #region

            var contenerPantalla = products.Where(p => p.Descripcion.Contains("pantalla"));

            foreach (var p in contenerPantalla)
            {
                Console.WriteLine($"{p.Nombre} | {p.Descripcion} | {p.Precio} ");
            }


            #endregion

            // 28. Obtener el promedio de stock de los productos de la categoría "Almacenamiento".

            #region
            var obtenerStockAlmacenamiento = products.Where(p => p.Categoria == "Almacenamiento").Average(p => p.Stock);

            Console.WriteLine(obtenerStockAlmacenamiento);

            #endregion

            // 29. Obtener los productos creados en una fecha específica (20/12/2022)
            #region
            DateTime fechaABuscar = new DateTime(2023, 2, 5);
            var obtenerFechaEspecifica = products.Where(p => p.FechaCreacion.Date == fechaABuscar);

            foreach (var fecha in obtenerFechaEspecifica)
            {
                Console.WriteLine($"{fecha.Nombre} | {fecha.Descripcion} | {fecha.FechaCreacion} ");
            }
            #endregion

            // 30. Obtener los productos cuya ID sea par
            #region
            var ObtenerIdPar = products.Where(p => p.Id % 2 == 0);

            foreach (var evenId in ObtenerIdPar)
            {
                Console.WriteLine($"{evenId.Id} | {evenId.Nombre} | {evenId.Precio}");
            }
            #endregion

            // 31. Obtener los productos cuya ID sea impar.

            #region

            var ObtenerIdImpar = products.Where(p => p.Id % 2 == 1);

            foreach (var oddId in ObtenerIdImpar)
            {
                Console.WriteLine($"{oddId.Id} | {oddId.Nombre} | {oddId.Precio}");
            }

            #endregion

            // 32. Obtener los productos cuyo precio tenga un decimal mayor a .50.

            #region
            var obtenerPrecioDecimal = products.Where(p => p.Precio % 1 > 0.50m);

            foreach (var obtenerDecimal in obtenerPrecioDecimal)
            {
                Console.WriteLine($"{obtenerDecimal.Id} | {obtenerDecimal.Nombre} | {obtenerDecimal.Precio}");
            }

            #endregion

            // 33. Obtener los productos cuyo nombre tenga más de 10 caracteres.

            #region

            var obtenerNomProd = products.Where(p => p.Nombre.Length > 10);

            foreach (var prod in obtenerNomProd)
            {
                Console.WriteLine($" {prod.Id} | {prod.Nombre} | {prod.Categoria} | {prod.Precio}");
            }
            #endregion

            // 34. Obtener los productos cuyo stock sea un número primo

            #region

            var obtenerStockPrimos = products.Where(p => isPrime(p.Id));

            foreach (var primos in obtenerStockPrimos)
            {
                Console.WriteLine($"{primos.Id} | {primos.Nombre} | {primos.Precio}");
            }

            #endregion

            // 35. Obtener los productos cuyo nombre contenga la palabra "Pro".

            #region
            var productoConPro = products.Where(p => p.Nombre.Contains("Pfro"));

            foreach (var p in productoConPro)
            {
                Console.WriteLine($"{p.Id} | {p.Nombre} | {p.Descripcion} ");
            }

            #endregion

            //36. Obtener los productos cuyo stock sea un múltiplo de 5

            #region

            var stockMultiploDe5 = products.Where(p => p.Stock % 5 == 0);

            foreach (var stock in stockMultiploDe5)
            {
                Console.WriteLine($"{stock.Id} | {stock.Nombre} | {stock.Stock}");
            }

            #endregion

            // 37. Obtener los productos que tengan una descripción con más de 20 caracteres.

            #region

            var descripcionMayor20 = products.Where(d => d.Descripcion.Length > 20);

            foreach (var desc in descripcionMayor20)
            {
                Console.WriteLine($"{desc.Id} | {desc.Descripcion}");
            }

            #endregion

            // 38. Obtener los productos cuyo precio sea un número redondo (sin decimales).

            #region

            var obtenerNumeroRedondo = products.Where(p => p.Precio % 1 == .00m);

            foreach (var numRedondo in obtenerNumeroRedondo)
            {
                Console.WriteLine($"{numRedondo.Id} | {numRedondo.Nombre} | {numRedondo.Precio}");
            }

            #endregion

            // 39. Obtener los productos que tengan exactamente dos palabras en su nombre.
            #region
            var productosCon2Palabras = products.Where(p => p.Nombre.Split(" ").Length == 2);

            foreach (var palabras in productosCon2Palabras)
            {
                Console.WriteLine($"{palabras.Id} | {palabras.Nombre} | {palabras.Precio}");
            }

            #endregion

            // 40. Obtener la cantidad de productos que no pertenecen a la categoría "General".

            #region

            var productosNoGeneral = products.Where(p => p.Categoria != "General");

            foreach (var prod in productosNoGeneral)
            {
                Console.WriteLine($"{prod.Id} | {prod.Nombre} | {prod.Categoria} ");
            }

            #endregion


        }

        public bool isPrime(decimal n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i*i < n; i+=2)
            {
                if(n %i== 0) return false;
            }
            return true;
        }
    }
}

