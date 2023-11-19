import React from 'react';
import { View, Text, StyleSheet } from 'react-native';

const EventInfoCard = ({ event }) => {
  return (
    <View style={styles.container}>
      <View style={styles.titleContainer}>
        <Text style={styles.title}>{event.name}</Text>
      </View>
      <View style={styles.infoContainer}>
        <Text style={styles.date}>Date: {event.date}</Text>
        <Text style={styles.time}>Time: {event.time}</Text>
        <Text style={styles.location}>Location: {event.location}</Text>
        <Text style={styles.locationAddress}>Location Address: {event.locationAddress}</Text>
        <Text style={styles.type}>Type: {event.type}</Text>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    margin: 10,
    padding: 10,
    borderWidth: 1,
    borderRadius: 5,
    borderColor: 'white',
    backgroundColor: '#6C0B67A6',
  },
  titleContainer: {
    alignItems: 'flex-start',
    justifyContent: 'center',
  },
  title: {
    fontSize: 18,
    fontWeight: 'bold',
    color: '#FFFFFF',
  },
  infoContainer: {
    alignItems: 'flex-end',
  },
  date: {
    fontSize: 9,
    color: '#FFFFFF',
  },
  time: {
    fontSize: 9,
    color: '#FFFFFF',
  },
  location: {
    fontSize: 9,
    color: '#FFFFFF',
  },
  locationAddress: {
    fontSize: 9,
    color: '#FFFFFF',
  },
  type: {
    fontSize: 9,
    color: '#FFFFFF',
  },
});

export default EventInfoCard;
