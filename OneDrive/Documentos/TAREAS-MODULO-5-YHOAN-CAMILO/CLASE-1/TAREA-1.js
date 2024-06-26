// TAREA 1

//PUNTO 1 => Acceso y Modificación Básica de Datos: 
console.log("--------------------------------------------------")
console.log("PUNTO 1")
console.log("--------------------------------------------------")

let libros = [
    { titulo: 'El Hobbit', autor: 'J.R.R. Tolkien', paginas: 300 },
    { titulo: 'Cien años de soledad', autor: 'Gabriel García Márquez', paginas: 400 },
    { titulo: 'Harry Potter y la piedra filosofal', autor: 'J.K. Rowling', paginas: 350 }
];

console.log(`Titulo: ${libros[1].titulo} y su Autor es: ${libros[1].autor}`) // 1.1


libros[0].paginas = 350;  //1.2
console.log(libros[0].paginas)  //1.2


console.log(libros[0]) //1.3


let nuevoArr = libros.map(arr => ({ 

    titulo: arr.titulo, 
    autor: arr.autor
    
}))

console.log(nuevoArr) //1.4

//-----------------------------------------------------------------------------------

console.log("--------------------------------------------------")
console.log("PUNTO 2")
console.log("--------------------------------------------------")

//PUNTO 2 => Cálculo de Estadísticas Básicas: 

const estudiantes = [
    { nombre: "Pedro", edad: 29, promedio: 7.9 },
    { nombre: "Ana", edad: 33, promedio: 8.9 },
    { nombre: "Pablo", edad: 32, promedio: 9.5 },
    { nombre: "Juan", edad: 25, promedio: 6.0 },
    { nombre: "Maria", edad: 28, promedio: 7.3 },
    { nombre: "Andres", edad: 45, promedio: 8.7 },
];


let sumaEdad = 0;
let promedioEdad = 0;
let numEstudiantes = 0;
for(let i = 0; i < estudiantes.length; i++ ){

    sumaEdad += estudiantes[i].edad;
    numEstudiantes++;

}
console.log(sumaEdad) //2.1

promedioEdad = sumaEdad / numEstudiantes; //2.2

console.log(`La suma es: ${sumaEdad} y el promedio es: ${promedioEdad}`) //2.3

//-----------------------------------------------------------------------------------

console.log("--------------------------------------------------")
console.log("PUNTO 3")
console.log("--------------------------------------------------")

//PUNTO 3 =>  Búsqueda y Filtrado de Datos:

let productos = [
    { nombre: 'Camisa', categoria: 'Ropa', precio: 20 },
    { nombre: 'Computadora', categoria: 'Electrónica', precio: 800 },
    { nombre: 'Zapatos', categoria: 'Ropa', precio: 50 },
    { nombre: 'Teléfono', categoria: 'Electrónica', precio: 300 }
];

let arrRopa = productos.filter( producto => producto.categoria === "Ropa")
console.log(arrRopa) // 3.1


let preciosMayores = productos.filter(producto => producto.precio > 30)
console.log(preciosMayores) //3.2








