import React, { useEffect, useState } from 'react';
import { StyleSheet, View, Text, ScrollView } from 'react-native';
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
});

export default EventsPage;
