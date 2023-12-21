using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Backprop; 

namespace BackPropagation
{
    public partial class Form1 : Form
    {
        private NeuralNet neuralNetwork;
        private List<TrainingData> trainingData;

        public Form1()
        {
            InitializeComponent();
            trainingData = GenerateANDTrainingData();
        }

        private void createBPNN_Click(object sender, EventArgs e)
        {
            Tuple<int, int> optimalSettings = FindOptimalSettings();
            neuralNetwork = new NeuralNet(4, optimalSettings.Item1, 1);
            MessageBox.Show($"Neural Network Initialized with {optimalSettings.Item1} hidden neurons.");
        }

        private void trainNN_Click(object sender, EventArgs e)
        {
            Tuple<int, int> optimalSettings = FindOptimalSettings();
            TrainNetwork(optimalSettings.Item2);
            MessageBox.Show("Training Completed with " + optimalSettings.Item2 + " epochs.");
        }

        private void Test_Click(object sender, EventArgs e)
        {
            TestNetwork();
        }

        private List<TrainingData> GenerateANDTrainingData()
        {
            var trainingData = new List<TrainingData>();
            for (int i = 0; i < 16; i++)
            {
                var inputs = Convert.ToString(i, 2).PadLeft(4, '0')
                    .Select(c => Convert.ToDouble(c.ToString())).ToArray();
                var output = inputs.All(input => input == 1) ? 1 : 0;
                trainingData.Add(new TrainingData(inputs, output));
            }
            return trainingData;
        }

        private void TrainNetwork(int epochs)
        {
            foreach (var data in trainingData)
            {
                for (int i = 0; i < data.Inputs.Length; i++)
                {
                    neuralNetwork.setInputs(i, data.Inputs[i]);
                }
                neuralNetwork.setDesiredOutput(0, data.Output);

                for (int epoch = 0; epoch < epochs; epoch++)
                {
                    neuralNetwork.learn();
                }
            }
        }

        private void TestNetwork()
        {
            try
            {
                double[] inputs = new double[] {
                    Convert.ToDouble(firstInput.Text),
                    Convert.ToDouble(secondInput.Text),
                    Convert.ToDouble(thirdInput.Text),
                    Convert.ToDouble(fourthInput.Text)
                };

                for (int i = 0; i < inputs.Length; i++)
                {
                    neuralNetwork.setInputs(i, inputs[i]);
                }

                neuralNetwork.run();
                oneOutput.Text = neuralNetwork.getOuputData(0).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
        }

        private Tuple<int, int> FindOptimalSettings()
        {
            int minHiddenNeurons = 0; 
            int maxHiddenNeurons = 10; 
            int minEpochs = 0; 
            int maxEpochs = 100; 
            double bestError = double.MaxValue;
            double acceptableError = 0.01; 

            for (int hiddenNeurons = minHiddenNeurons; hiddenNeurons <= maxHiddenNeurons; hiddenNeurons++)
            {
                for (int epochs = minEpochs; epochs <= maxEpochs; epochs += 10) 
                {
                    neuralNetwork = new NeuralNet(4, hiddenNeurons, 1);
                    double error = TrainAndEvaluate(epochs);

                    if (error < bestError)
                    {
                        bestError = error;
                        minHiddenNeurons = hiddenNeurons;
                        minEpochs = epochs;
                    }

                    if (error <= acceptableError)
                    {
                        return new Tuple<int, int>(hiddenNeurons, epochs);
                    }
                }
            }

            return new Tuple<int, int>(minHiddenNeurons, minEpochs);
        }


        private double TrainAndEvaluate(int epochs)
        {
            TrainNetwork(epochs);
            return CalculateMeanSquaredError();
        }

        private double CalculateMeanSquaredError()
        {
            double totalError = 0;
            foreach (var data in trainingData)
            {
                for (int i = 0; i < data.Inputs.Length; i++)
                {
                    neuralNetwork.setInputs(i, data.Inputs[i]);
                }
                neuralNetwork.run();
                double error = Math.Pow(data.Output - neuralNetwork.getOuputData(0), 2);
                totalError += error;
            }
            return totalError / trainingData.Count;
        }

        private void calMin_Click(object sender, EventArgs e)
        {
            Tuple<int, int> optimalSettings = FindOptimalSettings();
            label1.Text = "Min Hidden Neurons: " + optimalSettings.Item1;
            label2.Text = "Min Training Epochs: " + optimalSettings.Item2;
        }

        private class TrainingData
        {
            public double[] Inputs { get; }
            public double Output { get; }

            public TrainingData(double[] inputs, double output)
            {
                Inputs = inputs;
                Output = output;
            }
        }

    }
}
