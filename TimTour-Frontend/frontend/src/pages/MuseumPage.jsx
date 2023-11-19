import React, { useEffect, useState } from 'react';
import { StyleSheet, View, Image, ScrollView } from 'react-native';
import { useGlobalContext } from '../context/GlobalContext';
import axios from 'axios';
import MuseumInfoCard from '../components/MuseumInfoCard';

const MuseumPage = () => {
  const { backendURL } = useGlobalContext();
  const [museumData, setMuseumData] = useState([]);

  useEffect(() => {
    axios
      .get(`${backendURL}/museums`)
      .then((response) => {
        console.log('Museum data:', response.data);
        setMuseumData(response.data);
      })
      .catch((error) => {
        console.error('Error fetching events:', error);
      });
  }, [backendURL]);

  return (
    <View style={styles.container}>
        <Image
          source={require('../../assets/museumlefttop.png')}
          style={styles.image}
        />
      {museumData.map((museum, index) => (
        <MuseumInfoCard key={museum.id || index} museum={museum}/>

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

export default MuseumPage;
