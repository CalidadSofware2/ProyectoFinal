Documentación basica de como usar la api:

GET/api/TiendaRopa/inventario
Esta API muestra todos los productos registrados en el inventario.
En el api correspondiente:
1. se amplia la sección
2. se selecciona el boton 'Try it out'
3. seleccionar botón 'execute'
Esto devolverá la lista de todos los productos de inventario.


POST/api/TiendaRopa/inventario
Esta API permite el crear un nuevo inventario.
En swagger, en la sección de la api correspondiente:
1. se amplia la sección 
2. se selecciona el botón 'Try it out'
3. se completa el código con los datos de inventario
4. se presiona el botón de 'execute'
Esto agregará un nuevo  inventario y devolverá la información recién creada.


GET/api/TiendaRopa/inventario/{id}
Esta Api muestra un inventario especifico con respecto a su identificador (ID)
En swagger, en la sección de la api correspondiente:
1. se amplia la sección
2. se selecciona el botón 'Try it out'
3. se ingresa el valor del ID en el campo habilitado 
4. se presiona el botón de 'execute'
Esto devolverá la información de inventario con respecto al ID ingresado.


PUT/api/TiendaRopa/inventario/{id}
Esta api va a permitir el actualizar la información de un inventario con respecto a su identificador (ID)
en la sección de la api:
1. se amplia la sección 
2. se selecciona el botón 'Try it out'. 
3. se ingresa el valor del ID en el campo habilitado.
4. se completa el código con los datos del inventario
5. se presiona el botón de 'execute'
Esto actualizará la información del inventario con respecto al ID ingresado. 


DELETE/api/TiendaRopa/inventario/{id}
Está api permitirá eliminar un inventario con respecto a su identificador (ID)
En swagger, en la sección de la api correspondiente:
1. se amplia la sección 
2. se selecciona el botón 'Try it out'. 
3. se ingresa el valor del ID en el campo habilitado.
4. se presiona el botón de 'execute'
Esto hará que se elimine el inventario correspondiente al ID ingresado.


GET/api/TiendaRopa/producto
Esta api muestra todos los productos registrados en la base de datos.
En swagger, en la sección de la api correspondiente:
1. se amplia la sección
2. se selecciona el boton 'Try it out'
3. seleccionar botón 'execute'
Esto devolverá la lista de todos los productos registrados


POST/api/TiendaRopa/producto
Esta API permite el crear un nuevo producto en el sistema.
En swagger, en la sección de la api correspondiente:
1. se amplia la sección 
2. se selecciona el botón 'Try it out'
3. se completa el código con los datos de producto
4. se presiona el botón de 'execute'
Esto agregará un nuevo producto y devolverá la información recién creada.


GET/api/TiendaRopa/producto/{id}
Esta Api muestra un producto especifico con respecto a su identificador (ID)
En swagger, en la sección de la api correspondiente:
1. se amplia la sección
2. se selecciona el botón 'Try it out'
3. se ingresa el valor del ID en el campo habilitado 
4. se presiona el botón de 'execute'
Esto devolverá la información de producto con respecto al ID ingresado.


PUT/api/TiendaRopa/producto/{id}
Esta api va a permitir el actualizar la información de un producto con respecto a su identificador (ID)
en la sección de la api:
1. se amplia la sección 
2. se selecciona el botón 'Try it out'. 
3. se ingresa el valor del ID en el campo habilitado.
4. se completa el código con los datos del producto
5. se presiona el botón de 'execute'
Esto actualizará la información del producto con respecto al ID ingresado. 


DELETE/api/TiendaRopa/producto/{id}
Está api permitirá eliminar un producto con respecto a su identificador (ID)
En swagger, en la sección de la api correspondiente:
1. se amplia la sección 
2. se selecciona el botón 'Try it out'. 
3. se ingresa el valor del ID en el campo habilitado.
4. se presiona el botón de 'execute'
Esto hará que se elimine el producto correspondiente al ID ingresado.


GET/api/TiendaRopa/detalle
Esta api muestra todos los detalles registrados en un inventario.
En swagger, en la sección de la api correspondiente:
1. se amplia la sección
2. se selecciona el boton 'Try it out'
3. seleccionar botón 'execute'
Esto devolverá la lista de todos los detalles de inventario registrados, incluyendo la información relacionada del producto e inventario.


POST/api/TiendaRopa/detalle
Esta API permite el crear un nuevo detalle para un inventario.
En swagger, en la sección de la api correspondiente:
1. se amplia la sección 
2. se selecciona el botón 'Try it out'
3. se completa el código con los datos de detalle a registrar
4. se presiona el botón de 'execute'
Esto agregará un nuevo detalle y devolverá la información recién creada.


PUT/api/TiendaRopa/detalle
Esta api va a permitir el actualizar la información de un detalle del inventario
en la sección de la api correspondiente:
1. se amplia la sección 
2. se selecciona el botón 'Try it out'. 
3. se completa el código con los datos del detalle
5. se presiona el botón de 'execute'
Esto actualizará la información del detalle correspondiente en el inventario.


DELETE/api/TiendaRopa/detalle
Está api permitirá eliminar un detalle del inventario según el identificador del producto e inventario.
En swagger, en la sección de la api correspondiente:
1. se amplia la sección 
2. se selecciona el botón 'Try it out'. 
3. se ingresan los valores de productoid e inventarioid en los campos habilitados.
4. se presiona el botón de 'execute'
Esto hará que se elimine el detalle correspondiente a esos identificadores en el inventario.
