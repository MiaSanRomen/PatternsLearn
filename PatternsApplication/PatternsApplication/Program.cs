// See https://aka.ms/new-console-template for more information
using Patterns.Library.Behavioral.Chain_of_Responsibility;
using Patterns.Library.Behavioral.Command.Commands;
using Patterns.Library.Behavioral.Command.Reciever;
using Patterns.Library.Behavioral.Command.Senders;
using Patterns.Library.Behavioral.Iterator;
using Patterns.Library.Behavioral.Iterator.CustomCollections;
using Patterns.Library.Behavioral.Mediator;
using Patterns.Library.Behavioral.Memento;
using Patterns.Library.Behavioral.Observer;
using Patterns.Library.Behavioral.Observer.LandLords;
using Patterns.Library.Behavioral.State;
using Patterns.Library.Behavioral.State.ExperienceStates;
using Patterns.Library.Behavioral.Strategy;
using Patterns.Library.Behavioral.Strategy.SquadStrategies;
using Patterns.Library.Behavioral.TemplateMethod;
using Patterns.Library.Behavioral.Visitor.ConsoleActions;
using Patterns.Library.Behavioral.Visitor.ProgrammingHelpers;
using Patterns.Library.Creational.AbstractFactory.Blacksmith;
using Patterns.Library.Creational.Builder;
using Patterns.Library.Creational.FactoryMethod.Creator;
using Patterns.Library.Creational.Prototype;
using Patterns.Library.Creational.Singleton;
using Patterns.Library.Structural.Adapter;
using Patterns.Library.Structural.Bridge.Soldiers;
using Patterns.Library.Structural.Bridge.Squad;
using Patterns.Library.Structural.Composite;
using Patterns.Library.Structural.Decorator;
using Patterns.Library.Structural.Facade;
using Patterns.Library.Structural.Flyweight;
using Patterns.Library.Structural.Proxy;
using System;
using System.Net.WebSockets;




///////////////////////////// Visitor ////////////////////////////////////////////////

//Console.WriteLine("Here is our task!");
//ConsoleInput consoleInput = new ConsoleInput("a");
//ConsoleOutput consoleOutput = new ConsoleOutput("Hello world");
//ConsoleClear consoleClear = new ConsoleClear();

//Console.WriteLine("\nLet's make it using C++!");
//CppHelper cppHelper = new CppHelper();
//Console.WriteLine(consoleInput.GetCommand(cppHelper));
//Console.WriteLine(consoleOutput.GetCommand(cppHelper));
//Console.WriteLine(consoleClear.GetCommand(cppHelper));

//Console.WriteLine("\nLet's make it using C#!");
//CSharpHelper csharpHelper = new CSharpHelper();
//Console.WriteLine(consoleInput.GetCommand(csharpHelper));
//Console.WriteLine(consoleOutput.GetCommand(csharpHelper));
//Console.WriteLine(consoleClear.GetCommand(csharpHelper));

///////////////////////////// Template Method ////////////////////////////////////////////////

//Console.WriteLine("Let's build military and civil cities!");
//BaseCityBuilder civilCityBuilder = new CivilCityBuilder();
//BaseCityBuilder militaryCityBuilder = new MilitaryCityBuilder();
//
//Console.WriteLine("\nCivil city:");
//Console.WriteLine(civilCityBuilder.BuildMainHouse());
//Console.WriteLine(civilCityBuilder.BuildTemple());
//Console.WriteLine(civilCityBuilder.BuildWalls());
//
//Console.WriteLine("\nMilitary city:");
//Console.WriteLine(militaryCityBuilder.BuildMainHouse());
//Console.WriteLine(militaryCityBuilder.BuildTemple());
//Console.WriteLine(militaryCityBuilder.BuildWalls());

///////////////////////////// Strategy ////////////////////////////////////////////////

//Console.WriteLine("Scout squad, you need to find and bring here enemy's general!");
//ScoutSquad scoutSquad = new ScoutSquad();
//Console.WriteLine(scoutSquad.Activity());
//scoutSquad.Strategy = new FightStrategy();
//Console.WriteLine(scoutSquad.Activity());
//scoutSquad.Strategy = new RetreatStrategy();
//Console.WriteLine(scoutSquad.Activity());

///////////////////////////// State ////////////////////////////////////////////////

//Console.WriteLine("Centurion, here is your new squad!");
//SquadWithXp squad = new SquadWithXp(new Newcomers());
//Console.WriteLine(squad.Fight());
//Console.WriteLine(squad.State.GrowUp());
//Console.WriteLine(squad.Fight());
//Console.WriteLine(squad.State.GrowUp());
//Console.WriteLine(squad.Fight());
//Console.WriteLine(squad.State.GrowUp());
//Console.WriteLine(squad.Fight());
//Console.WriteLine(squad.State.GrowUp());
//Console.WriteLine(squad.Fight());
//Console.WriteLine(squad.State.Worse());
//Console.WriteLine(squad.Fight());
//Console.WriteLine(squad.State.Worse());
//Console.WriteLine(squad.Fight());
//Console.WriteLine(squad.State.Worse());
//Console.WriteLine(squad.Fight());
//Console.WriteLine(squad.State.Worse());

///////////////////////////// Proxy ////////////////////////////////////////////////

//Console.WriteLine("Here is President talk live. You may ask questions.");
//ICallService callService = new CallProxy(new CallPresidentServer());
//await callService.AskQuestion("Thank you!");
//await callService.AskQuestion("You're great!");
//await callService.AskQuestion("Who stolen our taxes?!");
//await callService.AskQuestion("We love you!");
//await callService.AskQuestion("Murder!");

///////////////////////////// Observer ////////////////////////////////////////////////

//Console.WriteLine("King they declared war to us!");
//King king = new King();
//Count count = new Count();
//Duke duke1 = new Duke();
//Duke duke2 = new Duke();
//Console.WriteLine("Call my lords!");
//king.AddLandLord(count);
//king.AddLandLord(duke1);
//king.AddLandLord(duke2);
//Console.WriteLine("Bring your armies immediately!");
//king.GatherArmies();
//Console.WriteLine("Sir, one of out dukes betrayed us!");
//king.RemoveLandLord(duke2);
//king.GatherArmies();

///////////////////////////// Flyweight ////////////////////////////////////////////////

//Console.WriteLine("Let's form our new Army!");
//List<Legionary> legionaries = new List<Legionary>();
//const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//Array armors = Enum.GetValues(typeof(ArmorType));
//Random random = new Random();
//for (int i = 0; i < 100; i++)
//{
//    string name = new string(Enumerable.Repeat(chars, 8)
//        .Select(s => s[random.Next(s.Length)]).ToArray());
//    ArmorType armorType = (ArmorType)armors.GetValue(random.Next(armors.Length));
//    Legionary legionary = new Legionary(name, armorType);
//    legionaries.Add(legionary);
//}

//foreach(Legionary legionary in legionaries)
//{
//    Console.WriteLine($"\nLegionary: {legionary.Name} \nArmor: Name:{legionary.Armor.Name} Color:{legionary.Armor.Color.Name}");
//}

///////////////////////////// Memento ////////////////////////////////////////////////

//Console.WriteLine("We need to develop a new sheep for our fleet.");
//DevelopedSheep sheep = new DevelopedSheep();
//Console.WriteLine("We need to record all changes");
//DevelopmentHistory developmentHistory = new DevelopmentHistory(sheep);
//sheep.SetLength(50);
//sheep.SetOars(200);
//sheep.SetSails(2);
//developmentHistory.SaveMemento();
//Console.WriteLine(sheep.ToString());

//sheep.SetLength(70);
//sheep.SetOars(280);
//sheep.SetSails(3);
//Console.WriteLine(sheep.ToString());
//developmentHistory.Undo();
//Console.WriteLine(sheep.ToString());

///////////////////////////// Facade ////////////////////////////////////////////////

//Console.WriteLine("Call commander!");
//CommanderFacade commander = new CommanderFacade();

//Console.WriteLine("\nCreate me a new legion!");
//Console.WriteLine(commander.PrepareLegion());

//Console.WriteLine("\nTrain my legion!");
//Console.WriteLine(commander.TrainSoldiers());

//Console.WriteLine("\nMove my army to Panonia!");
//Console.WriteLine(commander.SendLegion());

//Console.WriteLine("\nDestroy this markomans!");
//Console.WriteLine(commander.DefeatEnemy());

///////////////////////////// Singleton ////////////////////////////////////////////////

//Singleton sObjectOne = Singleton.GetInstance();
//Console.WriteLine(sObjectOne.ToString());
//Singleton sObjectTwo = Singleton.GetInstance();
//Console.WriteLine(sObjectTwo.ToString());
//Singleton sObjectThree = Singleton.GetInstance();
//Console.WriteLine(sObjectThree.ToString());

///////////////////////////// Mediator ////////////////////////////////////////////////

//Console.WriteLine("Crew prepare tank for battle!");
//TankMediator tank = new TankMediator();
//tank.Tower.TurnTower();
//tank.Gun.Reload();
//tank.Aim.Focus();
//tank.Gun.Fire();

///////////////////////////// Decorator ///////////////////////////////////////////////

//Console.WriteLine("We need more spies to look for third reich!");
//BasicSpyLogic shtirliz = new BasicSpyLogic("Shtirliz");
//ArmyTarget firstArmy = new ArmyTarget(1);
//firstArmy.AddTargetToSpy(shtirliz);
//ArmyTarget secondArmy = new ArmyTarget(2);
//secondArmy.AddTargetToSpy(firstArmy);
//ArmyTarget thirdArmy = new ArmyTarget(3);
//thirdArmy.AddTargetToSpy(secondArmy);
//FleetTarget firstFleet = new FleetTarget(1);
//firstFleet.AddTargetToSpy(thirdArmy);
//Console.WriteLine(firstFleet.Spy());

//BasicSpyLogic stashynsky = new BasicSpyLogic("Stashynsky");
//ArmyTarget fourthArmy = new ArmyTarget(4);
//fourthArmy.AddTargetToSpy(stashynsky);
//FleetTarget secondFleet = new FleetTarget(2);
//secondFleet.AddTargetToSpy(fourthArmy);
//Console.WriteLine(secondFleet.Spy());

///////////////////////////// Prototype ///////////////////////////////////////////////

//Console.WriteLine("We need new tanks to send them to front! Construct something!");
//HeavyTank heavyTank = new HeavyTank("KV-1", "KV-gun", "DT-1", "DT-1A");
//LightTank lightTank = new LightTank("BT-7", "BT-gun", "DT-2", "Degtyarev");
//Console.WriteLine("Tanks developed:");
//Console.WriteLine(heavyTank.GetInfo());
//Console.WriteLine(lightTank.GetInfo());

//Console.WriteLine("Great! Create and send to battle 4 KV-1 and 3 BT-7!");
//Console.WriteLine("Tanks were created and sended to war:");
//for(int i = 0; i < 4; i++)
//{
//    var copiedTank = heavyTank.Clone();
//    Console.WriteLine(((HeavyTank)copiedTank).GetInfo());
//}

//for (int i = 0; i < 3; i++)
//{
//    var copiedTank = lightTank.Clone();
//    Console.WriteLine(((LightTank)copiedTank).GetInfo());
//}

///////////////////////////// Iterator ///////////////////////////////////////////////

//Console.WriteLine("I want to know all cohorts in my legion!");
//IArmyIterable<Cohort> legion = new IterableLegion();
//var iterator = legion.getArmyIterator();
//while(iterator.HasMore())
//{
//    Console.WriteLine(iterator.GetNext().Name);
//}

///////////////////////////// Composite ///////////////////////////////////////////////

//Console.WriteLine("Let's record villages and cities.");
//City rome = new City("Rome", 500000);
//City neaples = new City("Neaples", 20000);
//City athens = new City("Athens", 100000);

//Country armini = new Country("Armini", 5000);
//Country sparta = new Country("Sparta", 7000);

//Province lacium = new Province("Lacium");
//lacium.AddCity(rome);
//lacium.AddVillage(armini);
//Province magnaGreece = new Province("Magna Greece");
//magnaGreece.AddCity(neaples);
//Province ellada = new Province("Ellada");
//ellada.AddCity(athens);
//ellada.AddVillage(sparta);

//Region italy = new Region("Italy");
//italy.AddProvince(lacium);
//italy.AddProvince(magnaGreece);
//Region greece = new Region("Greece");
//greece.AddProvince(ellada);

//Console.WriteLine($"Taxes from {greece.Name}: {greece.CollectTaxes()}");
//Console.WriteLine($"Taxes from {italy.Name}: {italy.CollectTaxes()}");

//Director director = new Director();
//var newLegion = director.CreateLegion();
//Console.WriteLine("The legion is ready!");
//Console.WriteLine($"Commander: {newLegion.CommanderTitle}. Home: {newLegion.HomeCity}. Banner: {newLegion.Banner}. Legioners: {newLegion.Legioners}.");
//var newAuxilaries = director.CreateAuxilary();
//Console.WriteLine("The auxilaries are ready!");
//Console.WriteLine($"Commander: {newAuxilaries.Commander}. Home: {newAuxilaries.HomeProvince}.  Soldiers: {newAuxilaries.Soldiers}.");

///////////////////////////// Builder ///////////////////////////////////////////////

//Console.WriteLine("Call the armies director! I need a legion and one more auxilary army.");
//Director director = new Director();
//var newLegion = director.CreateLegion();
//Console.WriteLine("The legion is ready!");
//Console.WriteLine($"Commander: {newLegion.CommanderTitle}. Home: {newLegion.HomeCity}. Banner: {newLegion.Banner}. Legioners: {newLegion.Legioners}.");
//var newAuxilaries = director.CreateAuxilary();
//Console.WriteLine("The auxilaries are ready!");
//Console.WriteLine($"Commander: {newAuxilaries.Commander}. Home: {newAuxilaries.HomeProvince}.  Soldiers: {newAuxilaries.Soldiers}.");

///////////////////////////// Command ///////////////////////////////////////////////

//Legion legion = new Legion();
//MoveCommand moveCommand = new MoveCommand(legion);
//AttackCommand attackCommand = new AttackCommand(legion);
//Console.WriteLine("Senat will get access to control legion moving.");
//BaseSender senate = new Senate();
//senate.SetCommand(moveCommand);
//Console.WriteLine("Province Governor will get access to send legion to attack.");
//BaseSender provinceGovernor = new ProvinceGovernor();
//provinceGovernor.SetCommand(attackCommand);
//Console.WriteLine(senate.ExecuteCommand("Rome"));
//Console.WriteLine(provinceGovernor.ExecuteCommand("Vandals"));

///////////////////////////// Bridge ///////////////////////////////////////////////

//Console.WriteLine("Our squads are ready! Roman and greek infantary and archers.");
//Squad romanInfantary = new InfantarySquad(new RomanSoldiers());
//Squad greekInfantary = new InfantarySquad(new GreekSoldiers());
//Squad romanArchers = new ArchersSquad(new RomanSoldiers());
//Squad greekArchers = new ArchersSquad(new GreekSoldiers());
//Squad[] squads = new Squad[] { romanInfantary, greekInfantary, romanArchers, greekArchers};

//Console.WriteLine("\nAttack!");
//foreach (Squad squad in squads)
//{
//    Console.WriteLine(squad.Attack());
//}

//Console.WriteLine("\nDefend!");
//foreach (Squad squad in squads)
//{
//    Console.WriteLine(squad.Defend());
//}

//Console.WriteLine("\nMove!");
//foreach (Squad squad in squads)
//{
//    Console.WriteLine(squad.Move());
//}

//Console.WriteLine("\nRetreat!");
//foreach (Squad squad in squads)
//{
//    Console.WriteLine(squad.Retreat());
//}

///////////////////////////// Abstract Factory ///////////////////////////////////////////////

//IArmorBlacksmith armorBlacksmith;
//Console.WriteLine("Ave roman warrior! Who are you?");
//Console.WriteLine("1. Infantaryman");
//Console.WriteLine("2. Horseman");
//int soldierTypeId = int.Parse(Console.ReadLine());
//armorBlacksmith = soldierTypeId == 1 ? new InfantaryBlacksmith() : new HorsemenBlacksmith();
//var sword = armorBlacksmith.CreateSword();
//Console.WriteLine($"Here is your sword: {sword.Name}. Length: {sword.Length} cm");
//var shield = armorBlacksmith.CreateShield();
//Console.WriteLine($"Here is your shield: {shield.Name}. Material: {shield.Material}");

///////////////////////////// Chain of Responsibility ///////////////////////////////////////////////

//Console.WriteLine("All availiable reinforcements prepare! How many?!");
//IReinforcement fortReinforcement = new FortReinforcement(5000, "Fort cohorts");
//IReinforcement provinceReinforcement = new ProvinceReinforcement(15000, "Province legions");
//IReinforcement counsulReinforcement = new CounsulReinforcement(25000, "Counsul armies");
//IReinforcement imperialReinforcement = new ImperialReinforcement(50000, "Army of the Emperor");

//fortReinforcement.SetNextReinforcementStage(provinceReinforcement);
//provinceReinforcement.SetNextReinforcementStage(counsulReinforcement);
//counsulReinforcement.SetNextReinforcementStage(imperialReinforcement);
//Console.WriteLine("Barbarians are attacking!");
//int barbarians = int.Parse(Console.ReadLine());
//Console.WriteLine($"{fortReinforcement.VerifySufficiency(barbarians)} will be enough for this battle.");

///////////////////////////// Adapter ///////////////////////////////////////////////

//Console.WriteLine("We occupied this village and appointed locals to positions.");
//IRomanProvince romanProvince;
//Console.WriteLine("Call mayor!");
//romanProvince = new ProvinceToTribeAdapter();
//Console.WriteLine($"Ave, I was {romanProvince.GetCityMayor()} before.");
//Console.WriteLine("Call treasurer!");
//romanProvince = new ProvinceToTribeAdapter();
//Console.WriteLine($"Ave, I was {romanProvince.GetCityTreasurer()} before.");
//Console.WriteLine("Call priest!");
//romanProvince = new ProvinceToTribeAdapter();
//Console.WriteLine($"Ave, I was {romanProvince.GetCityPriest()} before.");

///////////////////////////// Factory method ///////////////////////////////////////////////

//Console.WriteLine("Call blacksmith!");
//IBlacksmith blacksmith;
//Console.WriteLine("I need sword!");
//blacksmith = new BlacksmithSwords();
//Console.WriteLine($"Here is your {blacksmith.CreateArmor().GetArmor()}");
//Console.WriteLine("Call another blacksmith!");
//Console.WriteLine("I need shield!");
//blacksmith = new BlacksmithShields();
//Console.WriteLine($"Here is your {blacksmith.CreateArmor().GetArmor()}");

///////////////////////////////////////////////////////////////////////////////////////////////
