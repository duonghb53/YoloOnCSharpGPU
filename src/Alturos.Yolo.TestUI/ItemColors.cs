using OpenCvSharp;
using System;
using System.Collections.Generic;

namespace Alturos.Yolo.TestUI
{
    public class ItemColors
    {
        public static string[] items = new string[] { "person", "bicycle", "car", "motorbike", "aeroplane", "bus", "train", "truck", "boat",
            "traffic light", "fire hydrant", "stop sign", "parking meter", "bench", "bird", "cat", "dog", "horse", "sheep", "cow", "elephant",
            "bear", "zebra", "giraffe", "backpack", "umbrella", "handbag", "tie", "suitcase", "frisbee", "skis", "snowboard", "sports ball",
            "kite", "baseball bat", "baseball glove", "skateboard", "surfboard", "tennis racket", "bottle", "wine glass", "cup", "fork",
            "knife", "spoon", "bowl", "banana", "apple", "sandwich", "orange", "broccoli", "carrot", "hot dog", "pizza", "donut",
            "cake", "chair", "sofa", "pottedplant", "bed", "diningtable", "toilet", "tvmonitor", "laptop", "mouse", "remote",
            "keyboard", "cell phone", "microwave", "oven", "toaster", "sink", "refrigerator", "book", "clock", "vase",
            "scissors", "teddy bear", "hair drier", "toothbrush" };

        public Dictionary<string, Scalar> colorsItem { get; set; }

        public ItemColors()
        {
            colorsItem = new System.Collections.Generic.Dictionary<string, Scalar>();
            //Random rd = new Random();
            foreach (var item in items)
            {
                colorsItem.Add(item, Scalar.RandomColor());
            }
        }
    }
}
