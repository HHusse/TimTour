import { View, Text, StyleSheet, Image } from "react-native";
import { useGlobalContext } from "../context/GlobalContext";
import React, { useEffect, useState } from "react";
import AccomodationInfoCard from "../components/AccomodationInfoCard";
import axios from "axios";
const AccomodationPage = () => {
  const { backendURL } = useGlobalContext();
  const [accomodationData, setAccomodationData] = useState([]);
  useEffect(() => {
    axios
      .get(`${backendURL}/hotels`)
      .then((response) => {
        console.log("Accomodation data:", response.data);
        setAccomodationData(response.data);
      })
      .catch((error) => {
        console.error("Error fetching hotels:", error);
      });
  }, []);
  return (
    <View style={styles.container}>
      <View style={styles.imageContainer}>
        <Image
          source={require("../../assets/titlu_accomodation.png")}
          style={styles.image}
        />
      </View>
      {accomodationData.map((accomodation, index) => (
        <AccomodationInfoCard
          key={accomodation.id || index}
          accomodation={accomodation}
        />
      ))}
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    flexDirection: "column",
  },
  imageContainer: {
    paddingTop: 15,
    paddingLeft: 15,
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    alignSelf: "flex-start",
  },
  image: {
    width: 215,
    height: 60,
  },
});

export default AccomodationPage;
