using System;

class Head
{
    private int energyConsumption;
    private int iq;
    private string skinMaterial;

    public int EnergyConsumption
    {
        get { return energyConsumption; }
        set { energyConsumption = value; }
    }

    public int IQ
    {
        get { return iq; }
        set { iq = value; }
    }

    public string SkinMaterial
    {
        get { return skinMaterial; }
        set { skinMaterial = value; }
    }

    public Head(int energyConsumption, int iq, string skinMaterial)
    {
        EnergyConsumption = energyConsumption;
        IQ = iq;
        SkinMaterial = skinMaterial;
    }

    public override string ToString()
    {
        return $"#Head:\n###Energy consumption: {EnergyConsumption}\n###IQ: {IQ}\n###Skin material: {SkinMaterial}";
    }
}

class Torso
{
    private int energyConsumption;
    private double processorSize;
    private string housingMaterial;

    public int EnergyConsumption
    {
        get { return energyConsumption; }
        set { energyConsumption = value; }
    }

    public double ProcessorSize
    {
        get { return processorSize; }
        set { processorSize = value; }
    }

    public string HousingMaterial
    {
        get { return housingMaterial; }
        set { housingMaterial = value; }
    }

    public Torso(int energyConsumption, double processorSize, string housingMaterial)
    {
        EnergyConsumption = energyConsumption;
        ProcessorSize = processorSize;
        HousingMaterial = housingMaterial;
    }

    public override string ToString()
    {
        return $"#Torso:\n###Energy consumption: {EnergyConsumption}\n###Processor size: {ProcessorSize:f1}\n###Corpus material: {HousingMaterial}";
    }
}

class Arm
{
    private int energyConsumption;
    private int reachDistance;
    private int fingersCount;

    public int EnergyConsumption
    {
        get { return energyConsumption; }
        set { energyConsumption = value; }
    }

    public int ReachDistance
    {
        get { return reachDistance; }
        set { reachDistance = value; }
    }

    public int FingersCount
    {
        get { return fingersCount; }
        set { fingersCount = value; }
    }

    public Arm(int energyConsumption, int reachDistance, int fingersCount)
    {
        EnergyConsumption = energyConsumption;
        ReachDistance = reachDistance;
        FingersCount = fingersCount;
    }

    public override string ToString()
    {
        return $"#Arm:\n###Energy consumption: {EnergyConsumption}\n###Reach: {ReachDistance}\n###Fingers: {FingersCount}";
    }
}

class Leg
{
    private int energyConsumption;
    private int strength;
    private int speed;

    public int EnergyConsumption
    {
        get { return energyConsumption; }
        set { energyConsumption = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public Leg(int energyConsumption, int strength, int speed)
    {
        EnergyConsumption = energyConsumption;
        Strength = strength;
        Speed = speed;
    }

    public override string ToString()
    {
        return $"#Leg:\n###Energy consumption: {EnergyConsumption}\n###Strength: {Strength}\n###Speed: {Speed}";
    }
}

class Robot
{
    private ulong energyCapacity;
    private Head head;
    private Torso torso;
    private Arm leftArm;
    private Arm rightArm;
    private Leg leftLeg;
    private Leg rightLeg;

    public ulong EnergyCapacity
    {
        get { return energyCapacity; }
        set { energyCapacity = value; }
    }

    public Head Head
    {
        get { return head; }
        set { head = value; }
    }

    public Torso Torso
    {
        get { return torso; }
        set { torso = value; }
    }

    public Arm LeftArm
    {
        get { return leftArm; }
        set { leftArm = value; }
    }

    public Arm RightArm
    {
        get { return rightArm; }
        set { rightArm = value; }
    }

    public Leg LeftLeg
    {
        get { return leftLeg; }
        set { leftLeg = value; }
    }

    public Leg RightLeg
    {
        get { return rightLeg; }
        set { rightLeg = value; }
    }

    public Robot(ulong energyCapacity)
    {
        EnergyCapacity = energyCapacity;
    }

    public long TotalEnergyConsumed => (long)Head.EnergyConsumption + Torso.EnergyConsumption + LeftArm.EnergyConsumption + RightArm.EnergyConsumption + leftLeg.EnergyConsumption + RightLeg.EnergyConsumption;

    public bool HasMissingPart()
    {
        return 
            head == null ||
            torso == null ||
            leftArm == null ||
            rightArm == null ||
            leftLeg == null ||
            rightLeg == null;
    }

    public override string ToString()
    {
        return $"Jarvis:\n{Head}\n{Torso}\n{LeftArm}\n{RightArm}\n{leftLeg}\n{RightLeg}";
    }
}

class Jarvis
{
    static void TryToAddArm(Robot jarvis, Arm arm)
    {
        if (jarvis.LeftArm == null)
        {
            jarvis.LeftArm = arm;
        }
        else if (jarvis.RightArm == null)
        {
            jarvis.RightArm = arm;
        }
        else if (jarvis.LeftArm.EnergyConsumption > arm.EnergyConsumption &&
            jarvis.RightArm.EnergyConsumption > arm.EnergyConsumption)
        {
            jarvis.LeftArm = arm;
        }
        else if (jarvis.LeftArm.EnergyConsumption > arm.EnergyConsumption)
        {
            jarvis.LeftArm = arm;
        }
        else if (jarvis.RightArm.EnergyConsumption > arm.EnergyConsumption)
        {
            jarvis.RightArm = arm;
        }
    }

    static void TryToAddLeg(Robot jarvis, Leg leg)
    {
        if (jarvis.LeftLeg == null)
        {
            jarvis.LeftLeg = leg;
        }
        else if (jarvis.RightLeg == null)
        {
            jarvis.RightLeg = leg;
        }
        else if (jarvis.LeftLeg.EnergyConsumption > leg.EnergyConsumption &&
            jarvis.RightLeg.EnergyConsumption > leg.EnergyConsumption)
        {
            jarvis.LeftLeg = leg;
        }
        else if (jarvis.LeftLeg.EnergyConsumption > leg.EnergyConsumption)
        {
            jarvis.LeftLeg = leg;
        }
        else if (jarvis.RightLeg.EnergyConsumption > leg.EnergyConsumption)
        {
            jarvis.RightLeg = leg;
        }
    }

    static void Main(string[] args)
    {
        ulong maximumEnergyCapacity = ulong.Parse(Console.ReadLine());

        Robot jarvis = new Robot(maximumEnergyCapacity);

        string input;

        while ((input = Console.ReadLine()) != "Assemble!")
        {
            string[] items = input.Split();
            
            string typeOfComponent = items[0];
            int energyConsumption = int.Parse(items[1]);

            switch (typeOfComponent)
            {
                case "Head":
                    int iq = int.Parse(items[2]);
                    string skinMaterial = items[3];

                    Head head = new Head(energyConsumption, iq, skinMaterial);

                    if (jarvis.Head == null || jarvis.Head.EnergyConsumption > head.EnergyConsumption)
                    {
                        jarvis.Head = head;
                    }
                    break;
                case "Torso":
                    double processorSize = double.Parse(items[2]);
                    string housingMaterial = items[3];

                    Torso torso = new Torso(energyConsumption, processorSize, housingMaterial);

                    if (jarvis.Torso == null || jarvis.Torso.EnergyConsumption > torso.EnergyConsumption)
                    {
                        jarvis.Torso = torso;
                    }
                    break;
                case "Arm":
                    int reachDistance = int.Parse(items[2]);
                    int fingersCount = int.Parse(items[3]);

                    Arm arm = new Arm(energyConsumption, reachDistance, fingersCount);
                    TryToAddArm(jarvis, arm);
                    break;
                case "Leg":
                    int strength = int.Parse(items[2]);
                    int speed = int.Parse(items[3]);

                    Leg leg = new Leg(energyConsumption, strength, speed);
                    TryToAddLeg(jarvis, leg);
                    break;
                default:
                    break;
            }
        }

        if (jarvis.HasMissingPart())
        {
            Console.WriteLine("We need more parts!");
        }
        else if (jarvis.TotalEnergyConsumed <= 0 ||
            (ulong)jarvis.TotalEnergyConsumed <= jarvis.EnergyCapacity)
        {
            if (jarvis.LeftArm.EnergyConsumption > jarvis.RightArm.EnergyConsumption)
            {
                Arm temp = jarvis.LeftArm;
                jarvis.LeftArm = jarvis.RightArm;
                jarvis.RightArm = temp;
            }

            if (jarvis.LeftLeg.EnergyConsumption > jarvis.RightLeg.EnergyConsumption)
            {
                Leg temp = jarvis.LeftLeg;
                jarvis.LeftLeg = jarvis.RightLeg;
                jarvis.RightLeg = temp;
            }

            Console.WriteLine(jarvis);
        }
        else
        {
            Console.WriteLine("We need more power!");
        }
    }
}