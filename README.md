# VehicleManagementSystem
Mini-Car Sale System
Visual studio 2019 used for development. Please use this framework to run the application.





Summary
Developed application which currently handle the sale of vehicle type car but have capability to add other types of vehicles as well.
For Demo purpose I have added Bike Vehicle along with car.

Technical Details:
1)	Form: 
Possibility: We can use one form for all vehicles by conditionally rendering fields as implemented in VehicleForm.js. Also we can create separate form which is vehicle specific like I created CarForm.js.
Implemented: But in this application I have used  VehicleForm for all types of vehicles and carForm  for car vehicle.
2)	Models: 
Possibility: we can use vehicle specific models or common model with nested vehicle specific model.
Implemented: I have used common model in this application.

3)	Controller Action method for submission: 
Possibility: we can use vehicle specific method or common method with dependency injection.
Implemented: I have used common method with dependency injection in this application so that when we add new vehicle type we don’t have to change much in our application.
Implemented scope of expansion using interface and dependency injection. This can also be achieved by abstract Factory pattern.
