using System;

class DebuggingExercise_InstructionSet
{
    static void Main(string[] args)
    {
        string opCode;

        while ((opCode = Console.ReadLine()) != "END")
        {
            string[] codeArgs = opCode.Split(' ');

            long result = 0;

            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = ++operandOne;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = --operandOne;
                        break;
                    }
                case "ADD":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = (long)operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = (long)operandOne * operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);
        }
    }
}