string[] inputMassOfStrings = {"antonim", "ant", "mole", "pow"};
int inputMassLength = 4;
int outputMassLength = 0;
int inputMassIndex = 0;
int outputMassIndex = 0;

while(inputMassIndex < inputMassLength)
{
    if(inputMassOfStrings[inputMassIndex].Length <= 3)
        outputMassLength = outputMassLength + 1;
    
    inputMassIndex = inputMassIndex + 1;
}

string[] outputMassOfStrings = new string[outputMassLength];

inputMassIndex = 0;

while(outputMassIndex < outputMassLength)
{
    if(inputMassOfStrings[inputMassIndex].Length <= 3)
    {
        outputMassOfStrings[ outputMassIndex ] =   inputMassOfStrings[ inputMassIndex ];
        outputMassIndex = outputMassIndex + 1;
    }

    inputMassIndex = inputMassIndex + 1;

}