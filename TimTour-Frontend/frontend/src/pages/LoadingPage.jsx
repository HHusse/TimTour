import React, { useEffect } from "react";
import { View, Text, Image, StyleSheet, Dimensions } from "react-native";
import Svg, { Circle, Animate } from "react-native-svg";

const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;

const LoadingPage = ({ navigation }) => {
  const svgString = `
    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 200 200">
      <Circle fill="#DCB1DA" stroke="#DCB1DA" stroke-width="5" r="10" cx="40" cy="65">
        <Animate attributeName="cy" calcMode="spline" dur="2" values="65;135;65;" keySplines=".5 0 .5 1;.5 0 .5 1" repeatCount="indefinite" begin="-.4"></Animate>
      </Circle>
      <Circle fill="#DCB1DA" stroke="#DCB1DA" stroke-width="5" r="10" cx="100" cy="65">
        <Animate attributeName="cy" calcMode="spline" dur="2" values="65;135;65;" keySplines=".5 0 .5 1;.5 0 .5 1" repeatCount="indefinite" begin="-.2"></Animate>
      </Circle>
      <Circle fill="#DCB1DA" stroke="#DCB1DA" stroke-width="5" r="10" cx="160" cy="65">
        <Animate attributeName="cy" calcMode="spline" dur="2" values="65;135;65;" keySplines=".5 0 .5 1;.5 0 .5 1" repeatCount="indefinite" begin="0"></Animate>
      </Circle>
    </svg>
  `;

  useEffect(() => {
    const timer = setTimeout(() => {
      navigation.navigate('Home');
    }, 2000);

    // Clear the timer on component unmount
    return () => clearTimeout(timer);
  }, [navigation]);

  return (
    <View style={styles.container}>
      <Image
        source={require("../../assets/LoadingPageTop.jpeg")}
        style={styles.image}
      />
      <Svg width="200" height="200">
        {React.createElement("svg", {
          dangerouslySetInnerHTML: { __html: svgString },
        })}
      </Svg>
      <Text style={styles.text}>Powered by FullControl</Text>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  image: {
    position: 'absolute',
    top: 0,
    right: 0,
    width: windowWidth * 0.50,
    height: windowHeight * 0.30,
  },
  text: {
    position: 'absolute',
    bottom: windowHeight * 0.10,
    color: '#9F469B',
  },
});

export default LoadingPage;
