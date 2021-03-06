﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using Verse.Sound;

namespace EdB.PrepareCarefully {
    public class CustomHeadType {
        private CrownType crownType;
        private string graphicsPath;
        public string AlienCrownType {
            get; set;
        }
        private Gender? gender;
        public CrownType CrownType {
            get {
                return crownType;
            }
            set {
                crownType = value;
            }
        }
        public string GraphicPath {
            get {
                return graphicsPath;
            }
            set {
                graphicsPath = value;
            }
        }
        public Gender? Gender {
            get {
                return gender;
            }
            set {
                gender = value;
            }
        }
        public string Label {
            get; set;
        }
        public CustomHeadType() {

        }
        protected static string GetHeadLabel(string path) {
            try {
                string[] pathValues = path.Split('/');
                string crownType = pathValues[pathValues.Length - 1];
                string[] values = crownType.Split('_');
                return values[values.Count() - 2] + ", " + values[values.Count() - 1];
            }
            catch (Exception) {
                Log.Warning("Prepare Carefully could not determine head type label from graphics path: " + path);
                return "EdB.PC.Common.Default".Translate();
            }
        }
        public override string ToString() {
            return "{ label = \"" + Label + "\", graphicsPath = \"" + graphicsPath + "\", crownType = " + crownType + "\", AlienCrownType = " + AlienCrownType + ", gender = " + gender + "}";
        }
    }
}
