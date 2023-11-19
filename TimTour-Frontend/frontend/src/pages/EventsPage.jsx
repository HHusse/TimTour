import React, { useEffect, useState } from 'react';
import { StyleSheet, View, Image, ScrollView } from 'react-native';
import { useGlobalContext } from '../context/GlobalContext';
import axios from 'axios';
import EventInfoCard from '../components/EventInfoCard';

const EventsPage = () => {
  const { backendURL } = useGlobalContext();
  const [eventsData, setEventsData] = useState([]);

  useEffect(() => {
    axios
      .get(`${backendURL}/events`)
      .then((response) => {
        console.log('Events data:', response.data);
        setEventsData(response.data);
      })
      .catch((error) => {
        console.error('Error fetching events:', error);
      });
  }, [backendURL]);

  return (
    <View style={styles.container}>
      <View style={styles.imageContainer}>
        <Image
            source={require('../../assets/eventslefttop.png')} 
            style={styles.image}
        />
      </View>
      <ScrollView>
        {eventsData.map((event, index) => (
          <View key={event.id || index} style={styles.cardContainer}>
            <EventInfoCard event={event} />
          </View>
        ))}
      </ScrollView>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flexGrow: 1,
    alignItems: 'center',
    justifyContent: 'center',
  },
  pageTitle: {
    fontSize: 20,
    fontWeight: 'bold',
    marginBottom: 10,
  },
  imageContainer: {
    paddingTop:20,
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

export default EventsPage;
