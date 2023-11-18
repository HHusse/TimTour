import React from "react";
import { View } from "react-native";
import Svg, { Circle, Animate } from "react-native-svg";

const MyComponent = () => {
  const svgString = `
    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 200 200">
      <Circle fill="%23BA8ABC" stroke="%23BA8ABC" stroke-width="7" r="15" cx="40" cy="65">
        <Animate attributeName="cy" calcMode="spline" dur="2" values="65;135;65;" keySplines=".5 0 .5 1;.5 0 .5 1" repeatCount="indefinite" begin="-.4"></Animate>
      </Circle>
      <Circle fill="%23BA8ABC" stroke="%23BA8ABC" stroke-width="7" r="15" cx="100" cy="65">
        <Animate attributeName="cy" calcMode="spline" dur="2" values="65;135;65;" keySplines=".5 0 .5 1;.5 0 .5 1" repeatCount="indefinite" begin="-.2"></Animate>
      </Circle>
      <Circle fill="%23BA8ABC" stroke="%23BA8ABC" stroke-width="7" r="15" cx="160" cy="65">
        <Animate attributeName="cy" calcMode="spline" dur="2" values="65;135;65;" keySplines=".5 0 .5 1;.5 0 .5 1" repeatCount="indefinite" begin="0"></Animate>
      </Circle>
    </svg>
  `;

  return (
    <View>
      <Svg width="200" height="200">
        {React.createElement("svg", {
          dangerouslySetInnerHTML: { __html: svgString },
        })}
      </Svg>
    </View>
  );
};

export default MyComponent;
