import React, { useEffect, useState } from 'react';
import { StyleSheet, View, Image } from 'react-native';
import { useGlobalContext } from "../context/GlobalContext";
import axios from 'axios';
import BarInfoCard from "../components/BarInfoCard";

const BarsPage = () => {
 const { backendURL } = useGlobalContext();
 const [barsData, setBarsData] = useState([]);

 useEffect(() => {
    axios.get(`${backendURL}/bars`)
      .then(response => {
        console.log('Bars data:', response.data);
        setBarsData(response.data);
      })
      .catch(error => {
        console.error('Error fetching bars:', error);
      });
 }, []);

 return (
    <View style={styles.container}>
       <View style={styles.imageContainer}>
        <Image
          source={require('../../assets/barlefttop.png')}
          style={styles.image}
        />
      </View>
      {barsData.map((bar, index) => (
        <BarInfoCard key={bar.id || index} bar={bar} />
      ))}
    </View>
 );
};

const styles = StyleSheet.create({
 container: {
    flex: 1,
    flexDirection: 'column',
    paddingTop: 15,
    paddingLeft: 15,
  },
  imageContainer: {
    paddingTop: 15,
    paddingLeft:15,
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    alignSelf: 'flex-start',
  },
   image: {
      width: 215,
      height: 60,
   },
});

export default BarsPage;
