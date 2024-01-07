namespace Drone;

public class Drone
{
    Motor[] motors = new[]
    { 
        new Motor() { Propeller = new Propeller() { PropellerType = Enums.PropellerType.Left} }, 
        new Motor() { Propeller = new Propeller() { PropellerType = Enums.PropellerType.Right} }, 
        new Motor() { Propeller = new Propeller() { PropellerType = Enums.PropellerType.Left} }, 
        new Motor() { Propeller = new Propeller() { PropellerType = Enums.PropellerType.Right} }
    };
}
